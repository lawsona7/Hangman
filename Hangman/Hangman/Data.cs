using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    class Data
    {
        public List<String> Easy { get; set; }
        public List<String> Normal { get; set; }
        public List<String> Hard { get; set; }

        public Data()
        {
            Easy = new List<string>();
            Normal = new List<string>();
            Hard = new List<string>();
            bool easy = false;
            bool normal = false;
            bool hard = false;
            

        }
    }
}
