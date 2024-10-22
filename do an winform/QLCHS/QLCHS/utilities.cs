using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.ConnectionUI;
using System.Windows.Forms;
using QLCHS.BussinessObject;

namespace QLCHS
{
    class utilities
    {
        //Hàm lấy mã tiếp theo
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

        //Thông tin tài khoản
        public static TaikhoanObj tk = new TaikhoanObj();

        //Hàm mở connection dialog
        public static void OpenConnDialog() 
        {
            string path = Directory.GetCurrentDirectory() + @"\config.txt";

            Microsoft.Data.ConnectionUI.DataConnectionDialog _dialog = new
                Microsoft.Data.ConnectionUI.DataConnectionDialog();
            Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(_dialog);

            Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(_dialog);
            if (_dialog.DialogResult.ToString().Equals("OK"))
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        string connec = _dialog.ConnectionString;
                        writer.WriteLine(connec);
                        writer.Close();
                    }
                }
            }
        }

        //Connect database dialog
        static string result;
        public static string getConnect()
        {
            string curentDirectory = Directory.GetCurrentDirectory();
            string path = Directory.GetCurrentDirectory() + @"\config.txt";

            if (!File.Exists(path))
            {
                OpenConnDialog();
            }
            else 
            {
                FileStream stream = new FileStream(path, FileMode.Open);

                StreamReader reader = new StreamReader(stream);
                result = reader.ReadLine();
                reader.Close();
            }
            return result;
        }

    }
}
