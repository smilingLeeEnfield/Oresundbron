using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron
{
    public class OresundCar : bridge.Car
    {
        public OresundCar(string LP, bool biz) : base(LP, biz)
        {
        }
        /// <summary>
        /// returns price of a car ticket on the Øresund bridge with a discount if brobizz is used
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (brobizz) return 178;
            return 460;
        }
    }
}
