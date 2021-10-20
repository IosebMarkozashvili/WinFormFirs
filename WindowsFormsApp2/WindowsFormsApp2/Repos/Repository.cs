using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Repos
{
   public class Repository
    {

        public string RemoveWhitespace(string input)
        {
            try
            {
                return new string(input.ToCharArray()
               .Where(c => !Char.IsWhiteSpace(c))
               .ToArray());
            }
            catch
            {
                return "";

            };
        }

    }
}
