
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;


namespace Autokauppa.model
{
    




    public class DatabaseHallinta
    {

        string yhteysTiedot;
        SqlConnection dbYhteys = new SqlConnection();
        SqlDataReader myReader;
        SqlCommand command;

        public DatabaseHallinta()
        {
            yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;

            try
            {
                dbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO auto (ID,Hinta,Rekisteri_paivamaara,Moottorin_tilavuus,Mittarilukema," +
                "AutonMerkkiID,AutonMalliID,VaritID,PolttoaineID) VALUES (" +
                "@Id, @Hinta, @paivamaara, @tilavuus, @mittari, @MerkkiID, @MalliID, @VaritID, @PolttoaineID)");
            command.Parameters.AddWithValue("@Id", newAuto.Id);
            command.Parameters.AddWithValue("@Hinta", newAuto.Hinta);
            command.Parameters.AddWithValue("@paivamaara", newAuto.Rekisteri_paivamaara);
            command.Parameters.AddWithValue("@tilavuus", newAuto.Moottorin_tilavuus);
            command.Parameters.AddWithValue("@mittari", newAuto.Mittarilukema);
            command.Parameters.AddWithValue("@MerkkiID", newAuto.AutonMerkkiID);
            command.Parameters.AddWithValue("@MalliID", newAuto.AutonMalliID);
            command.Parameters.AddWithValue("VaritID", newAuto.VaritID);
            command.Parameters.AddWithValue("PolttoaineID", newAuto.PolttoaineID);

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            bool palaute = false;
            return palaute;


        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> AutonMerkit = new List<AutonMerkki>();
            SqlCommand command = new SqlCommand("SELECT * FROM AutonMerkki",
                                                                    dbYhteys);
            try
            {
                command.ExecuteNonQuery();
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        AutonMerkki autonMerkki = new AutonMerkki();

                        autonMerkki.Id = Convert.ToInt32(myReader["ID"]);
                        autonMerkki.MerkkiNimi = myReader["Merkki"].ToString();

                        AutonMerkit.Add(autonMerkki);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return AutonMerkit;

        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId)
        {
            List<AutonMalli> autonMallit = new List<AutonMalli>();
            command = new SqlCommand("SELECT * FROM AutonMallit WHERE AutonMerkkiID =@makerId",
                                                         dbYhteys);
            command.Parameters.AddWithValue("@makerId", makerId);

            try
            {
                command.ExecuteNonQuery();
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        AutonMalli autonMalli = new AutonMalli();

                        autonMalli.Id = Convert.ToInt32(myReader["ID"]);
                        autonMalli.MalliNimi = myReader["Auton_mallin_nimi"].ToString();
                        autonMalli.MerkkiId = Convert.ToInt32(myReader["AutonMerkkiID"]);

                        autonMallit.Add(autonMalli);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return autonMallit;
        }
        public List<Polttoaine> GetAllFuelsFromDatabase()
        {
            List<Polttoaine> Fuels = new List<Polttoaine>();
            command = new SqlCommand("SELECT * FROM Polttoaine", 
                                                            dbYhteys);
            try
            {
                command.ExecuteNonQuery();
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Polttoaine polttoaine = new Polttoaine();

                        polttoaine.Id = Convert.ToInt32(myReader["Id"]);
                        polttoaine.Polttoaineen_nimi = myReader["Polttoaineen_nimi"].ToString();

                        Fuels.Add(polttoaine);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Fuels;
        }

        public List<Varit> GetAllColorsFromDatabase()
        {
            List<Varit> Colors = new List<Varit>();
            command = new SqlCommand("SELECT * FROM Varit", 
                                                    dbYhteys);
            try
            {
                command.ExecuteNonQuery();
                using (myReader = command.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Varit color = new Varit();

                        color.Id = Convert.ToInt32(myReader["Id"]);
                        color.Varin_nimi = myReader["Varin_nimi"].ToString();

                        Colors.Add(color);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return Colors;
        }

    }
}
