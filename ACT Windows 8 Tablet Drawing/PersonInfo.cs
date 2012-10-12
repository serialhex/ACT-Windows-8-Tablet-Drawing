using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Windows_8_Tablet_Drawing {
    public class PersonInfo {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City{ get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public override string ToString() {
            string str = FirstName + LastName + Phone + EMail + Address1 + Address2 + City + State + Zip;
            return str;
        }
    }
}
