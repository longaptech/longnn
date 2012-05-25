using System;
using System.Collections.Generic;
using System.Text;

namespace QLCHS
{
    class utilities
    {
        public static string nextID(string lastID, string prefixID) 
        {
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumberID = lastID.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumberID; i++ )
            {
                if(nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumberID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;
        }
    }
}
