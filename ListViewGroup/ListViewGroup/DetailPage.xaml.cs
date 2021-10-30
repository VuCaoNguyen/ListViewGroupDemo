using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        void FormInitializing(City selectedCity)
        {
            city.Text = selectedCity.name;
            coutry.Text = selectedCity.nameCountry;
            imageDetail.Source = selectedCity.image;
        }
        public DetailPage()
        {
            InitializeComponent();
        }
        public DetailPage(City selectedCity)
        {
            InitializeComponent();
            FormInitializing(selectedCity);
        }
    }
}