using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewGroup
{
    public partial class MainPage : ContentPage
    {
        List<Country> listCountry;

        void InitCity()
        {
            listCountry = new List<Country>();

            Country VietNam = new Country("Việt Nam");
            VietNam.Add(new City {id = "1", name = "Hà Nội", image = "hanoi.jpg",nameCountry="Việt Nam" });
            VietNam.Add(new City { id = "2", name = "Hồ Chí Minh", image = "hcm.jpg", nameCountry = "Việt Nam" });
            VietNam.Add(new City { id = "3", name = "Đà Nẵng", image = "dn.jpg", nameCountry = "Việt Nam" });


            Country HanQuoc = new Country("Hàn Quốc");
            HanQuoc.Add(new City { id = "4", name = "Soul", image = "hq1.jpg", nameCountry = "Hàn Quốc" });
            HanQuoc.Add(new City { id = "5", name = "Busan", image = "hq2.jpg", nameCountry = "Hàn Quốc" });

            Country Uc = new Country("Úc");
            Uc.Add(new City { id = "6", name = "Sydney", image = "uc1.jpg", nameCountry = "Úc" });
            Uc.Add(new City { id = "7", name = "Melbourne", image = "uc2.jpg", nameCountry = "Úc" });

            Country Anh = new Country("Anh Quốc");
            Anh.Add(new City { id = "8", name = "Manchester", image = "anh1.jpg", nameCountry = "Anh Quốc" });
            Anh.Add(new City { id = "9", name = "Liverpool", image = "anh2.jpg", nameCountry = "Anh Quốc" });

            listCountry.Add(VietNam);
            listCountry.Add(HanQuoc);
            listCountry.Add(Uc);
            listCountry.Add(Anh);

            listcity.ItemsSource = listCountry;
        }
        public MainPage()
        {
            InitializeComponent();
            InitCity();

            
        }

        private void pickCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listcity_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listcity.SelectedItem != null)
            {

                Navigation.PushAsync(new DetailPage( selectedCity:(City)listcity.SelectedItem));
            }
        }
    }
}
