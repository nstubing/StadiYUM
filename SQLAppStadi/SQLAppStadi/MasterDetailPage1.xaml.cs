using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLAppStadi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var page = (MasterDetailPage1MenuItem)e.SelectedItem;
            string newPageTitle = page.Title;
            Navigation.PushAsync(new ConcessionMenu(newPageTitle));

            
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}