using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_agenda
{
    class conexion
    {
        public static SQLiteConnection conectar()
        {
            string database = Application.StartupPath + "\\myagenda.db;";
            SQLiteConnection cn = new SQLiteConnection("datasource = " + database);
            return cn;
        }
    }
}
