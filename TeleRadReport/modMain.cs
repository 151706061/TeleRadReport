using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;

namespace TeleRadReport
{
    class modMain
    {
        public static DataSet DS = new DataSet();
        public static string UID = "";
        public static string PWD = "";
        public static int UType = 0;
        public static string PatName = "";
        public static string PatDOB = "";
        public static string PatSex = "";
        public static string StudyID = "";
        public static string StudyDate = "";

        public static string StudyTime = "";
        public static bool Retreived = false;
    }
}
