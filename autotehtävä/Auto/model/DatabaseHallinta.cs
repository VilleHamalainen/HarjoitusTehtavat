
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
        SqlConnection dbYhteys;
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
            catch(Exception e)
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

        public List<int> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> AutonMerkit = new List<AutonMerkki>();
            SqlCommand command = new SqlCommand("SELECT Merkki FROM AutonMerkki",
                                                                    dbYhteys);
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                AutonMerkki autonMerkki = new AutonMerkki();
                autonMerkki.MerkkiNimi = myReader["Merkki"].ToString();
                AutonMerkit.Add(autonMerkki);
            }

            
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            List<int> palaute = new List<int>{0,1};
            return palaute;

        }

        public List<int> getAutoModelsByMakerId(int makerId) 
             
        {
            List<int> palaute = null;
            return palaute;
        }

    }
}
