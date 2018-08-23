using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLAppStadi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConcessionMenu : ContentPage
    {
        public ObservableCollection<Item > Items { get; set; }

        public ConcessionMenu(string concession)
        {
            InitializeComponent();
            using (SQLite.SQLiteConnection db = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                var ThisConsesh =db.Table<Concession>().Where(I => I.Name == concession).FirstOrDefault();
                var theseItems = db.Table<ConcessionItem>().Where(I => I.ConcessionId == ThisConsesh.Id).ToList();
                //var TheseItemObserve = new ObservableCollection<Item>(theseItems);
                //Items = TheseItemObserve;
            }
            

                MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            var itemModel = (ConcessionItem)item.CommandParameter;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
