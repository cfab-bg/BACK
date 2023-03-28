using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffApi.Models{
    public class Employer{    

        public int EmployerID { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public string? Date { get; set; }
        public string? Salaire { get; set; }
        public string? Poste { get; set; }
        public bool Transport{ get; set;}
        public bool Cantine{ get; set;}
        public bool Caps{ get; set;}
        public bool Ostie{ get; set;}

    }
}