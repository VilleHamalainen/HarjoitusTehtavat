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
        
       

        private void LoadDataSources()
        {
            Merkki_cBox.Items.AddRange(registerHandler.getAllAutoMakers().ToArray());
            Merkki_cBox.DisplayMember = "MerkkiNimi";
            color_cBox.Items.AddRange(registerHandler.GetAllColors().ToArray());
            color_cBox.DisplayMember = "Varin_nimi";
            fuel_cBox.Items.AddRange(registerHandler.GetAllFuels().ToArray());
            fuel_cBox.DisplayMember = "Polttoaineen_nimi";

            /*
            Merkki_cBox.DataSource = registerHandler.getAllAutoMakers().Select(AutonMerkki => AutonMerkki.MerkkiNimi).ToList();
            fuel_cBox.DataSource = registerHandler.GetAllFuels().Select(Polttoaine => Polttoaine.Polttoaineen_nimi).ToList();
            color_cBox.DataSource = registerHandler.GetAllColors().Select(Varit => Varit.Varin_nimi).ToList();
           */
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            registerHandler.connectDB();
            LoadDataSources();
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
            if(Merkki_cBox.SelectedIndex == -1)
            {
                Malli_cBox.Text = "";
                Malli_cBox.Items.Clear();
            }
            else
            {
                Malli_cBox.Items.AddRange(registerHandler.getAutoModels(Merkki_cBox.SelectedIndex + 1).ToArray());
                Malli_cBox.DisplayMember = "MalliNimi";
            }
            
        }

        private void uusiAuto_btn_Click(object sender, EventArgs e)
        {
            //Clear textboxes
            mittarilukema.Text = "";
            tilavuus.Text = "";
            hinta.Text = "";

            //Blank first index Combobox
            Merkki_cBox.Text = "";
            Malli_cBox.Text = "";
            fuel_cBox.Text = "";
            color_cBox.Text = "";
        }
    }
}
