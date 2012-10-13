using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Windows.Storage;

namespace ACT_Windows_8_Tablet_Drawing {
    public class PersonInfo {

        // this is painful...
        private string first_name;
        public string FirstName {
            get {
                return first_name;
            }
            set {
                first_name = escape_string(value);
            }
        }

        private string last_name;
        public string LastName {
            get {
                return last_name;
            }
            set {
                last_name = escape_string(value);
            }
        }

        private string phone;
        public string Phone {
            get {
                return phone;
            }
            set {
                phone = escape_string(value);
            }
        }

        private string email;
        public string EMail {
            get {
                return email;
            }
            set {
                email = escape_string(value);
            }
        }

        private string address1;
        public string Address1 {
            get {
                return address1;
            }
            set {
                address1 = escape_string(value);
            }
        }

        private string address2;
        public string Address2 {
            get {
                return address2;
            }
            set {
                address2 = escape_string(value);
            }
        }

        private string city;
        public string City{
            get {
                return city;
            }
            set {
                city = escape_string(value);
            }
        }

        public string State { get; set; }

        private string zip;
        public string Zip {
            get {
                return zip;
            }
            set {
                zip = escape_string(value);
            }
        }

        private string escape_string(string clean_me) {
            string clean;
            string[] words = Regex.Split(clean_me, @"\W+");
            clean = string.Join(" ", words);
            return clean;
        }

        public override string ToString() {
            string str = ToCSV();
            str += "next line";
            return str;
        }

        private string ToCSV() {
            string str = "";
            str += first_name + "; ";
            str += last_name + "; ";
            str += phone + "; ";
            str += email + "; ";
            str += address1 + "; ";
            str += address2 + "; ";
            str += city + "; ";
            str += State + "; ";
            str += zip + "\n";
            return str;
        }

        // FFS THIS IS A PAIN!!!
        // err, was, until i figured out i needed to use the *WINDOWS 8* API's for file writing,
        //    and not the *normal* api's for file writing!!!
        async public void writeFile() {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;

            string str = ToCSV();

            StorageFile file = await localFolder.CreateFileAsync("databaser.dat", CreationCollisionOption.OpenIfExists);
            await FileIO.AppendTextAsync(file, str);
        }
    }
}
