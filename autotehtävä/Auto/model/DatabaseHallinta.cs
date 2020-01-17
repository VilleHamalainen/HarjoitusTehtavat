
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
        
            
        

    }
}
