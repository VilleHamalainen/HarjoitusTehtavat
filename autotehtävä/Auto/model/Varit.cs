using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autokauppa.controller;
namespace Autokauppa.model
{
    public class Varit
    {
        private int id;
        private string varin_nimi;

        public int Id { get => id; set => id = value; }
        public string Varin_nimi { get => varin_nimi; set => varin_nimi = value; }
    }
}
