using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitcoin_odev
{
    class coin
    {
        public string[] info;

        public coin(string[] info_)
        {
           info = info_;
        }

        public void yazdir()        
        {
            for (int x = 0; x < info.Length; x++)
            {
                Console.Write(info[x] + "   ");

            }
            Console.Write("\n");
        }

    }
}
