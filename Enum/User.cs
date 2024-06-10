using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class User
    {
        public int Id { get; set; }
        public string Prenom {  get; set; }
        public string Nom { get; set; }
        public Ecolors Ecolors { get; set; }
    }
}
