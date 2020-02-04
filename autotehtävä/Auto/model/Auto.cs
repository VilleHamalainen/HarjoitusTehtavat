using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.controller;
namespace Autokauppa.model
{
    public class Auto: KaupanLogiikka
    {
        private int id;
        private decimal hinta;
        private DateTime rekisteri_paivamaara;
        private decimal moottorin_tilavuus;
        private int mittarilukema;
        private int autonMerkkiID;
        private int autonMalliID;
        private int varitID;
        private int polttoaineID;

        public int Id { get => id; set => id = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime Rekisteri_paivamaara { get => rekisteri_paivamaara; set => rekisteri_paivamaara = value; }
        public decimal Moottorin_tilavuus { get => moottorin_tilavuus; set => moottorin_tilavuus = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        public int AutonMerkkiID { get => autonMerkkiID; set => autonMerkkiID = value; }
        public int AutonMalliID { get => autonMalliID; set => autonMalliID = value; }
        public int VaritID { get => varitID; set => varitID = value; }
        public int PolttoaineID { get => polttoaineID; set => polttoaineID = value; }
    }
}
    