using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Owner
    {
        private int ID;
        private string Name;
        private string Organization;

        public Owner(int id, string name, string org)
        {
            ID = id;
            Name = name;
            Organization = org;
           
        }
        public void Info()
        {
            Console.WriteLine($"Owner: ID - {ID}, Name - {Name}, Organization - {Organization}");
        }
    }
}
