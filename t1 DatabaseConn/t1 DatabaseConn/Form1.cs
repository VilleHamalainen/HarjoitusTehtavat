using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace t1_DatabaseConn
{
    public partial class Form1 : Form
    {
        string opryhma;
        string selected;
        List<int> rows = new List<int>();
        List<string> Nimet = new List<string>();
        List<string> ryhma = new List<string>();

        

        public Form1()
        {
            InitializeComponent();
            
        }

        SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=WCF;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False");

        //Load
        private void Form1_Load(object sender, EventArgs e)
        {
            if (myConnection.State != ConnectionState.Open)
            {
                myConnection.Open();
            }

            try
            {
                SqlCommand command = new SqlCommand("SELECT opryhma FROM opryhma", myConnection);
                command.ExecuteNonQuery();

                SqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    ryhma.Add(myReader["opryhma"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            comboBox1.DataSource = ryhma;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Command String", myConnection);
            string Nimi = textBox1.Text;

            string ryhmaSelected = comboBox1.SelectedItem.ToString();

            
            //Getting currently selected Group
            command.CommandText = "SELECT Id FROM opryhma WHERE opryhma = @ryhmaSelected";
            command.Parameters.AddWithValue("@ryhmaSelected", ryhmaSelected);
            try
            {
                SqlDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    opryhma = myReader["Id"].ToString();
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //Adding a student with a group
            command.CommandText = "INSERT INTO Nimi (nimi), (opryhma) " +
                        "Values (@nimi), (@opryhma)";
            command.Parameters.AddWithValue("@nimi", Nimi);
            command.Parameters.AddWithValue("@opryhma", opryhma);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        //DataReader
        private void dataReader()
        {
            
            
        }

        //Show list
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Nimet.Clear();

                SqlCommand command = new SqlCommand("SELECT * FROM nimi",
                                                         myConnection);
                SqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Nimet.Add(myReader["nimi"].ToString());

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //dataReader();
            dataGridView1.DataSource = Nimet.ConvertAll(x => new { Value = x });
        }
        
        //DELETE ALL
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Nimet.Clear();
                
                SqlCommand command = new SqlCommand("DELETE FROM nimi",
                                                         myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Database cleared successfully!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //DELETE SELECTED
        private void remove_btn_Click(object sender, EventArgs e)
        {
            selected = dataGridView1.CurrentCell.Value.ToString();
            SqlCommand command = new SqlCommand("DELETE FROM nimi WHERE nimi = @selected", myConnection);
            command.Parameters.AddWithValue("@selected", selected);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //Load
        
    }
}
