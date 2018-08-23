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
                db.DropTable<Concession>();
                db.DropTable<ConcessionItem>();
                db.DropTable<Item>();
                db.DropTable<Order>();
                db.DropTable<RealUser>();
                db.CreateTable<Concession>();
                db.CreateTable<ConcessionItem>();
                db.CreateTable<Item>();
                db.CreateTable<Order>();
                db.CreateTable<RealUser>();
                //var AJBombers = db.Table<Concession>().Where(c => c.Name == "AJ Bombers").FirstOrDefault();
                //ConcessionItem concession1 = new ConcessionItem { ConcessionId = (int)AJBombers.Id, ItemId=0  };
                //db.Insert(concession1);
                //ConcessionItem concession2 = new ConcessionItem { ConcessionId = (int)AJBombers.Id, ItemId = 1 };
                //db.Insert(concession2);
                //ConcessionItem concession3 = new ConcessionItem { ConcessionId = (int)AJBombers.Id, ItemId = 2 };
                //db.Insert(concession3);
                //ConcessionItem concession4 = new ConcessionItem { ConcessionId = (int)AJBombers.Id, ItemId = 3 };
                //db.Insert(concession4);
                
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
