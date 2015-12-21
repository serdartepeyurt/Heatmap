using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatmap
{
    /// <summary>
    /// Heat masks are used when handling points passed to the GetHeatMap function.
    /// It specifies how heat falls off as you get further from the point.
    /// 
    /// </summary>
    class HeatMask
    {
        public int HeatMapXRadius { get; private set; }
        public int HeatMapYRadius { get; private set; }
        private float[][] HeatMaskArray;

        /*
        public HeatMask(int xRadius, int yRadius)
        {

            HeatMapXRadius = xRadius;
            HeatMapYRadius = yRadius;

            HeatMask = new float[xRadius][];

            for (int i = 0; i < xRadius; i++)
            {
                HeatMask[i] = new float[yRadius];
                
                //Instantiate array to 0.
                for (int j = 0; j < yRadius; j++)
                {
                    HeatMask[i][j] = 0;
                }
            }
           
        }
         * */

        /// <summary>
        /// Heat masks must be constructed with a pre-made mask.
        /// </summary>
        /// <param name="xRadius"></param>
        /// <param name="yRadius"></param>
        /// <param name="mask"></param>
        public HeatMask(int xRadius, int yRadius, float[][] mask)
        {
            HeatMapXRadius = xRadius;
            HeatMapYRadius = yRadius;
            HeatMaskArray = mask;
        }

        public float value(int x, int y)
        {
            return HeatMaskArray[x + HeatMapXRadius][y + HeatMapYRadius];
        }

    }
}
