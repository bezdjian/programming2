using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRF
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string tigername { get; set; }

        public User(int id, string name, string lastname, string address, string tigername)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.tigername = tigername;
        }
        public User()
        {

        }
    }
}
