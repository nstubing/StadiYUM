using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLAppStadi.Model;

namespace SQLAppStadi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RealUser newUser = new RealUser();
            newUser.Username = UsernameEntry.Text;
            newUser.Password = PasswordEntry.Text;
            
            using(SQLite.SQLiteConnection db = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                db.CreateTable<RealUser>();
                var ExistingUser = db.Table<RealUser>().Where(u => u.Username == newUser.Username).FirstOrDefault();
                if(ExistingUser==null)
                {
                    
                    db.Insert(newUser);
                    App.CurrentUser = newUser;
                    Navigation.PushAsync(new SeatEntry());

                }
                else if (ExistingUser.Username==newUser.Username && ExistingUser.Password==newUser.Password)
                {
                    App.CurrentUser = newUser;
                    Navigation.PushAsync(new SeatEntry());

                }
                else if (ExistingUser.Username == newUser.Username && ExistingUser.Password != newUser.Password)
                {
                    //db.CreateTable<Concession>();
                    //db.CreateTable<ConcessionItem>();
                    //db.CreateTable<Item>();
                    //db.CreateTable<Order>();
                    //db.CreateTable<Seats>();
                    //db.CreateTable<Stadium>();
                    //db.CreateTable<User>();
                    //Concession concession1 = new Concession { Name = "AJ Bombers", Section = 117 };
                    //db.Insert(concession1);
                    //Concession concession2 = new Concession { Name = "SmokeShack", Section = 118 };
                    //db.Insert(concession2);
                    //Concession concession3 = new Concession { Name = "J. Agave Tacos", Section = 123 };
                    //db.Insert(concession3);
                    //Concession concession4 = new Concession { Name = "Specialty Pretzels", Section = 111 };
                    //db.Insert(concession4);
                    //Concession concession5 = new Concession { Name = "Beer", Section = 119 };
                    //db.Insert(concession5);
                    DisplayAlert("Invalid Password", "Your username and password may be incorrect.", "Try again");
                }
            }
            
        }

        private void Sign_Up(object sender, EventArgs e)
        {

        }
    }
}
