using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLAppStadi.Model;

namespace SQLAppStadi
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeatEntry : ContentPage
	{
		public SeatEntry ()
		{
			InitializeComponent ();
		}

        private void SeatEntered(object sender, EventArgs e)
        {
            RealUser thisUser = App.CurrentUser;
            thisUser.CurrentSection = Int32.Parse(SectionEntry.Text);
            thisUser.Seat = Int32.Parse(Seat.Text);
            using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                db.Update(thisUser);
                App.CurrentUser = thisUser;
                Application.Current.MainPage = new NavigationPage(new MasterDetailPage1());
            }

        }
        private async void BackButton(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}