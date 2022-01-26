using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NyamNyam
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //ImportImage();

        }

        private void ImportImage()
        {
            DBEntities db = new DBEntities();
            foreach (var item in db.Dishes)
            {
                if (File.Exists( "image/"+item.ImagePath))
                {
                    item.MainImage = File.ReadAllBytes("image/" + item.ImagePath);
                }
            }
            db.SaveChanges();
        }
    }
}
