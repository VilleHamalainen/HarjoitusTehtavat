using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        

        KaupanLogiikka registerHandler;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            registerHandler.connectDB();
            Merkki_cBox.DataSource = registerHandler.getAllAutoMakers().Select(AutonMerkki => AutonMerkki.MerkkiNimi).ToList();
        }

        private void test_DBConnection_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void test_functions_Click(object sender, EventArgs e)
        {
            registerHandler.connectDatabase();
            foreach (AutonMalli autonMallit in registerHandler.getAutoModels(3))
            {
                Console.WriteLine(autonMallit.Id + " " + autonMallit.MalliNimi + " " + autonMallit.MerkkiId);
            }
        }

        private void Merkki_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Malli_cBox.DataSource = registerHandler.getAutoModels(Merkki_cBox.SelectedIndex + 1).Select(AutonMalli => AutonMalli.MalliNimi).ToList();

        }
    }
}
