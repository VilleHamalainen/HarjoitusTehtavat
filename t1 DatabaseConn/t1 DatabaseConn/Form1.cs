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
        string selected;
        List<int> rows = new List<int>();
        List<string> Nimet = new List<string>();
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

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Command String", myConnection);
            string Nimi = textBox1.Text;
            
            command.CommandText = "INSERT INTO Nimi (nimi) " +
                        "Values (@nimi)";
            command.Parameters.AddWithValue("@nimi", Nimi);
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dataReader()
        {
            try
            {
                Nimet.Clear();

                SqlCommand command = new SqlCommand("select * from nimi",
                                                         myConnection);
                SqlDataReader myReader = command.ExecuteReader();
                
                while (myReader.Read())
                {
                    Nimet.Add(myReader["nimi"].ToString());

                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show (e.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataReader();
            dataGridView1.DataSource = Nimet.ConvertAll(x => new { Value = x });
        }

        private void open_Conn_Click(object sender, EventArgs e)
        {
            myConnection.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Nimet.Clear();
                myConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM nimi",
                                                         myConnection);
                command.ExecuteReader();
                MessageBox.Show("Database cleared successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            selected = dataGridView1.CurrentCell.Value.ToString();
            SqlCommand command = new SqlCommand("DELETE FROM nimi WHERE nimi='@selected'", myConnection);
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

        public void delete()
        {
            

        }
    }
}
