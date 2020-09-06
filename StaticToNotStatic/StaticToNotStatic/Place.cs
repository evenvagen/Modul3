using System;
using System.Collections.Generic;
using System.Text;

namespace StaticToNotStatic
{
    class Place
    {
        public static void ShowPlace(string place, string county)
        {
            var labelWidth = 10;


            StarBorder(10);

            ShowFieldNameAndValue("Navn", labelWidth, place);
            ShowFieldNameAndValue("Kommune", labelWidth, county);
            StarBorder(labelWidth);
        }


        private static void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine(" " + label + ":" + string.Empty.PadLeft(labelWidth, ' ') + fieldValue);
        }

        private static void StarBorder(int labelWidth)
        {
            labelWidth += 10;
            Console.WriteLine(string.Empty.PadLeft(labelWidth, '*'));
        }

    }
}
