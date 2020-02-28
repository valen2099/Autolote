using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolote.BL
{
    class Contexto: DbContext
    {
        public Contexto(): base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename="+ 
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\AutoloteDB.mdf")
        {

        }

        public DbSet<Productos> Productos { get; set; }
    }
}
