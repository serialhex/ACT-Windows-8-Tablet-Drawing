using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ACT_Windows_8_Tablet_Drawing {
    class CleanString {

        private const string CleanChars = ";";

        private string self;
        public string Self {
            get {
                return self;
            }
            set {
                self = clean_string(value);
            }
        }

        public override string ToString() {
            return self;
        }

        private string clean_string(string clean_me) {
            string clean;
            string[] words = Regex.Split(clean_me, CleanChars);
            clean = string.Join("", words);
            return clean;
        }
    }
}
