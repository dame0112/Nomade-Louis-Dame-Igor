using System;
using System.Collections.Generic;
using System.Text;

namespace Nomade_Louis_Dame_Igor.Models
{
    public class Villes 

    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string CodePostale { get; set; }
        public List<Pays> Pays { get; set; }
       

    }
}