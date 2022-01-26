using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NyamNyam
{
    class Manager
    {
        public static Frame MainFrame { get; set; }
        public static DBEntities db { get; set; } = new DBEntities();
    }
}
