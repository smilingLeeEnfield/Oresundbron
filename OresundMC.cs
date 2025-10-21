using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron
{
    public class OresundMC : bridge.MC
    {
        public OresundMC(string LP, bool biz) : base(LP, biz)
        {
        }
        /// <summary>
        /// returns price of a MC ticket on the Øresund bridge with a discount if brobizz is used
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            if (brobizz) return 92;
            return 235;
        }
    }
}
