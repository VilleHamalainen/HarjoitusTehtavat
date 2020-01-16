using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    class AutonMerkki
    {
        private int id;
        private string merkkiNimi;

        public int Id { get => id; set => id = value; }
        public string MerkkiNimi { get => merkkiNimi; set => merkkiNimi = value; }
    }
}
