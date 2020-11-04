using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExplorationGame
{
    class Text_read_helper
    {

        public static String ascii(String FileUrl)
        {



            //file lines
            string[] lines = File.ReadAllLines(FileUrl);

            //loop through each file line
            string text = File.ReadAllText(FileUrl);
            return text;
        }
    }
}


