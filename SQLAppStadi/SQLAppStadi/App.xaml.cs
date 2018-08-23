using SQLAppStadi.Model;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQLAppStadi
{
    public partial class App : Application
    {
        public static string DB_PATH = string.Empty;
        public static RealUser CurrentUser { get; set; }
        public App()
        {
            string fileName = "StadiYUMdb.db";
            string fileLocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(fileLocation, fileName);
            DB_PATH = fullPath;
            using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection(DB_PATH))
            {
                Item concession1 = new Item { ItemName = "AJ Bombers", Price = 117, Image="" };
                db.Insert(concession1);
                Item concession2 = new Item { ItemName = "SmokeShack", Price = 118 };
                db.Insert(concession2);
                Item concession3 = new Item { ItemName = "J. Agave Tacos", Price = 123 };
                db.Insert(concession3);
                Item concession4 = new Item { ItemName = "Specialty Pretzels", Price = 111 };
                db.Insert(concession4);
                Item concession5 = new Item { ItemName = "Beer", Price = 119 };
                db.Insert(concession5);
            }

            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
