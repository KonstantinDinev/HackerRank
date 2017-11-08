using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class TimeConversion
    {
        static public void Init()
        {
            DateTime date = DateTime.Now;
            string hh = date.Hour.ToString().PadLeft(2, '0') +
                ":", mm = date.Minute.ToString().PadLeft(2, '0') + ":", ss = date.Second.ToString().PadLeft(2, '0');
            string buildTime = String.Concat(hh, mm, ss, date.ToString("tt", System.Globalization.CultureInfo.InvariantCulture));

            string s = buildTime;
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
        static string timeConversion(string time)
        {
            // Complete this function
            DateTime dateTime = DateTime.ParseExact(time, "HH:mm:sstt",
                                                    System.Globalization.CultureInfo.InvariantCulture);

            return dateTime.ToString("HH:mm:ss");
        }

    }
}

// In JavaScript
//function timeConversion(s)
//{
//    // Complete this function
//    var twentyFourClock = false;
//    var date = new Date();

//    var hh = s[0] + s[1];//date.getHours();
//    var mm = s[3] + s[4];//date.getMinutes();
//    var ss = s[6] + s[7];//date.getSeconds();

//    var buildTime = hh + ":" + mm + ":" + ss;
//    var twentyFourArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
//                          13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23];

//    if (s.length == 10)
//    {
//        twentyFourClock = false;
//        hh = s[0] + s[1];
//        if (s[8] == "P")
//        {
//            if (parseInt(s[0]) == 0 && parseInt(s[1]) != 0)
//            {
//                hh = twentyFourArray[parseInt(s[1]) + 12];
//            }
//            else if (parseInt(s[0]) != 0)
//            {
//                if (parseInt(s[0]) == 1 && parseInt(s[1]) == 2) hh = "00";
//                hh = twentyFourArray[parseInt(hh) + 12];
//            }
//        }
//        else
//        {
//            //console.log(s[8]+s[9]);
//            if (parseInt(s[0]) == 1 && parseInt(s[1]) == 2) hh = "00";
//        }

//        buildTime = hh + ":" + mm + ":" + ss;
//        return buildTime;
//    }
//    else
//    {
//        //tuk e AM/PM ot 24
//    }
//}