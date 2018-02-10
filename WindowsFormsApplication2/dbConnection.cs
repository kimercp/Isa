using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // needed for application startupPath

namespace ISAManagment
{
    class dbConnection
    {
        public static string dbConnect = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
        + Application.StartupPath + @"\Outlaw_Hess.accdb;";
    }
}
