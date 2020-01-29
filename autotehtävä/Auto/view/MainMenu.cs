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
        int currentID = 0;

        KaupanLogiikka registerHandler;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();

            if(registerHandler.connectDB() != true)
            registerHandler.connectDB();
            
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
            
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadDataSources();
        }

        private void test_DBConnection_Click(object sender, EventArgs e)
        {
            registerHandler.TestDatabaseConnection();
        }

        private void test_functions_Click(object sender, EventArgs e){}

        private void Merkki_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Merkki_cBox.SelectedIndex == -1)
            {
                Malli_cBox.Text = "";
                Malli_cBox.Items.Clear();
            }
            else
            {
                Malli_cBox.Items.Clear();
                Malli_cBox.Items.AddRange(registerHandler.getAutoModels(Merkki_cBox.SelectedIndex + 1).ToArray());
                Malli_cBox.DisplayMember = "MalliNimi";
                Malli_cBox.ValueMember = "Id";
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

        private void GetCarValues(object sender, EventArgs e)
        { 
            bool success = false;
            Auto newAuto = new Auto();
            
            if(newAuto.Id == 0)
            {
                ID_Label.Text = "ID: Not saved";
            }
            else
            {
               // newAuto.Id =;
            }

            //Price Type Check
            success = decimal.TryParse(hinta.Text, out decimal autonHinta);
            if (success)
                newAuto.Hinta = autonHinta;
            else
                MessageBox.Show("Price can only be numbers");

            //Mileage Type Check
            success = int.TryParse(mittarilukema.Text, out int setMittari);
            if (success)
                newAuto.Mittarilukema = setMittari;
            else
                MessageBox.Show("Mileage can only be numbers");

            //Engine Capacity Type Check
            success = decimal.TryParse(tilavuus.Text, out decimal MoTilavuus);
            if (success)
                newAuto.Moottorin_tilavuus = MoTilavuus;
            else
                MessageBox.Show("Engine capacity can only be numbers");



            Console.WriteLine(paivamaara_Picker);
            
            Merkki_cBox.ValueMember = "ID";
            
            newAuto.AutonMerkkiID = (Merkki_cBox.SelectedItem as AutonMerkki).Id;

            newAuto.AutonMalliID = (Malli_cBox.SelectedItem as AutonMalli).Id;

            newAuto.PolttoaineID = (fuel_cBox.SelectedItem as Polttoaine).Id;

            newAuto.VaritID = (color_cBox.SelectedItem as Varit).Id;

            //FIX DATE FORMATTING
            newAuto.Rekisteri_paivamaara = paivamaara_Picker.Value.Date;

            registerHandler.saveAuto(newAuto);
            
        }

        private void Tallenna_Click(object sender, EventArgs e)
        {
            GetCarValues(sender, e);
        }

        private void NextCar(object sender, EventArgs e)
        {
            //Init
            Auto newAuto = registerHandler.GetNextCar(currentID);
            Malli_cBox.Items.Clear();
            ID_Label.Text = "ID: " + newAuto.Id;
            currentID = newAuto.Id;

            //Textfield values
            hinta.Text = newAuto.Hinta.ToString();
            paivamaara_Picker.Value = new DateTime(newAuto.Rekisteri_paivamaara.Year, newAuto.Rekisteri_paivamaara.Month, newAuto.Rekisteri_paivamaara.Day);
            tilavuus.Text = newAuto.Moottorin_tilavuus.ToString();
            mittarilukema.Text = newAuto.Mittarilukema.ToString();

            Merkki_cBox.SelectedIndex = newAuto.AutonMerkkiID - 1;


            AutonMalli[] models = registerHandler.getAutoModels(newAuto.AutonMerkkiID).ToArray();
            foreach (AutonMalli malli in models)
            {
                Malli_cBox.Items.Add(malli);
            }
            Malli_cBox.DisplayMember = "MalliNimi";

            foreach (AutonMalli malli in models)
            {
                if (malli.Id == newAuto.AutonMalliID)
                {
                    Malli_cBox.SelectedItem = malli;
                    break;
                }
            }
            Malli_cBox.SelectedValue = newAuto.AutonMalliID.ToString();

            fuel_cBox.SelectedIndex = newAuto.PolttoaineID - 1;
            color_cBox.SelectedIndex = newAuto.VaritID - 1;
        }


        private void PreviousCar(object sender, EventArgs e)
        {
            Auto newAuto = registerHandler.GetPreviousCar(currentID);
            Malli_cBox.Items.Clear();
            ID_Label.Text = "ID: " + newAuto.Id;
            currentID = newAuto.Id;

            //Textfield values
            hinta.Text = newAuto.Hinta.ToString();
            paivamaara_Picker.Value = new DateTime(newAuto.Rekisteri_paivamaara.Year, newAuto.Rekisteri_paivamaara.Month, newAuto.Rekisteri_paivamaara.Day);
            tilavuus.Text = newAuto.Moottorin_tilavuus.ToString();
            mittarilukema.Text = newAuto.Mittarilukema.ToString();

            Merkki_cBox.SelectedIndex = newAuto.AutonMerkkiID - 1;


            AutonMalli[] models = registerHandler.getAutoModels(newAuto.AutonMerkkiID).ToArray();
            foreach (AutonMalli malli in models)
            {
                Malli_cBox.Items.Add(malli);
            }
            Malli_cBox.DisplayMember = "MalliNimi";

            foreach (AutonMalli malli in models)
            {
                if (malli.Id == newAuto.AutonMalliID)
                {
                    Malli_cBox.SelectedItem = malli;
                    break;
                }
            }
            Malli_cBox.SelectedValue = newAuto.AutonMalliID.ToString();

            fuel_cBox.SelectedIndex = newAuto.PolttoaineID - 1;
            color_cBox.SelectedIndex = newAuto.VaritID - 1;
        }


    }


}
