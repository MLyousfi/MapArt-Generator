using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.ImageProcessingFunction
{
    public class Constants
    {
        public static Color[] mineCraftColor = { 
            ColorTranslator.FromHtml("#f9ffff"),
            ColorTranslator.FromHtml("#9c9d97"),
            ColorTranslator.FromHtml("#474f52"),
            ColorTranslator.FromHtml("#1d1c21"),
            ColorTranslator.FromHtml("#ffd83d"),
            ColorTranslator.FromHtml("#f9801d"),
            ColorTranslator.FromHtml("#b02e26"),
            ColorTranslator.FromHtml("#825432"),
            ColorTranslator.FromHtml("#80c71f"),
            ColorTranslator.FromHtml("#5d7c15"),
            ColorTranslator.FromHtml("#3ab3da"),
            ColorTranslator.FromHtml("#169c9d"),
            ColorTranslator.FromHtml("#3c44a9"),
            ColorTranslator.FromHtml("#f38caa"),
            ColorTranslator.FromHtml("#c64fbd"),
            ColorTranslator.FromHtml("#8932b7"),
        
        };
    }
    public static class function
    {
        

        public static int GetDistance(Color current, Color match)
        {
           
            int redDifference;
            int greenDifference;
            int blueDifference;

            redDifference = current.R - match.R;
            greenDifference = current.G - match.G;
            blueDifference = current.B - match.B;

            return redDifference * redDifference + greenDifference * greenDifference + blueDifference * blueDifference;
        }

        public static int FindNearestColor(Color[] map, Color current)
        {
            int shortestDistance;
            int index;

            index = -1;
            shortestDistance = int.MaxValue;

            for (int i = 0; i < map.Length; i++)
            {
                Color match;
                int distance;

                match = map[i];
                distance = GetDistance(current, match);

                if (distance < shortestDistance)
                {
                    index = i;
                    shortestDistance = distance;
                }
            }

            return index;
        }
    }
}
