using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class UntilRequest
    {
        public int Until { get; set; }

        public int Add()
        {
            int added = 0;
            for(int a = 1; a <= Until; a++)
            {
                added += a;
            }
            return added;
        }

        public int Factor()
        {
            int factor = 1;
            for (int a = 1; a <= Until; a++)
            {
                factor *= a;
            }
            return factor;
        }
    }
}
