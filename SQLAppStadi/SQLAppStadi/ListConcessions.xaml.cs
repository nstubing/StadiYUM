using SQLAppStadi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLAppStadi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListConcessions : ContentPage
    {
        public ObservableCollection<Concession> Concessions;
        public ListConcessions()
        {
            InitializeComponent();
            using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                var Ctoncessions = db.Table<Concession>().ToList();
                Concessions = new ObservableCollection<Concession>(Ctoncessions);
            }

                

            MyListView.ItemsSource = Concessions;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var thisItem = (Concession)MyListView.SelectedItem;
            
            if (e.Item == null)
                return;
            await DisplayAlert("shit",thisItem.Name, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
        
    }
}
