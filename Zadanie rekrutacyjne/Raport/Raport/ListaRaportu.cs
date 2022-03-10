using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport
{
   public class ListaRaportu
    {
        public string Nazwa { get; set; }
        public DateTime Data { get; set; }
        public string Godzina { get; set; }
        public string Użytkownik { get; set; }
        public string Lokal { get; set; }
    }
}
