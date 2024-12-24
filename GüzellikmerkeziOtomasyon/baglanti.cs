using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GüzellikmerkeziOtomasyon
{
    internal class baglanti
    {


        public localEntities baglan()
        {
            return new localEntities();
        }
        public SqlConnection sqlbaglan()
        {
            return new SqlConnection(@"Data Source=DESKTOP-3L4M0RL;Initial Catalog=local;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
