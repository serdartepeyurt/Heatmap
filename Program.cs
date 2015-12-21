using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heatmap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> testData = new List<Point>();

            //Generate random data for the heat mapper.
            Random random = new Random((int)System.DateTime.Now.ToFileTime());
            for (int i = 0; i < 10000; i++)
            {
                testData.Add(new Point(random.Next(0, 1920), random.Next(0, 1080)));
            }

            //Set up the factory and run the GetHeatMap function.
            HeatmapFactory map = new HeatmapFactory();
            map.OpenOnComplete = true;
            map.InputMax = new Point(1920, 1080);
            map.OutputResolution = new Point(1920, 1080);
            map.SaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HeatMap.png";
            //map.ColorFunction = HeatmapFactory.GrayScale;
            map.ColorFunction = HeatmapFactory.BasicColorMapping;
            map.GetHeatMap(testData);


            Console.ReadKey();
        }
    }
}
