using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public class Motorola : Smartphone
    {
        public Motorola(long numero, string modelo, long imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarApp(string nomeApp)
        {
            base.InstalarApp(nomeApp);
            Console.WriteLine("no sistema Android.");
        }
    }
}
