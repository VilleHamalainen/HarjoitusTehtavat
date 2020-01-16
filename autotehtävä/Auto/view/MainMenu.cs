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

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        KaupanLogiikka shopLogic = new KaupanLogiikka();
        

        KaupanLogiikka registerHandler;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void test_DBConnection_Click(object sender, EventArgs e)
        {
            shopLogic.TestDatabaseConnection();
        }
    }
}
