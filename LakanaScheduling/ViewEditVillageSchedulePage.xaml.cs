using System;
using System.Collections.ObjectModel;
using Scheduling;
using Xamarin.Forms;

namespace LakanaScheduling
{
    public partial class ViewEditVillageSchedulePage : ContentPage
    {
        private ObservableCollection<Week> weeks { get; set; }

        public ViewEditVillageSchedulePage()
        {

            //InitializeComponent();

            //weeks = new ObservableCollection<Week>();

            //DateTime nextMonday = DateTime.Now.AddDays(1);
            //var w1 = new Week { Cycle = 1, Number = 1, StartDate = nextMonday, EndDate = nextMonday.AddDays(4) };
            //w1.Add(new Village { Name = "Bendougouba", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w1.Add(new Village { Name = "Bendougouni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w1.Add(new Village { Name = "Toumbougouni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w1.Add(new Village { Name = "Laminila", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w1.Add(new Village { Name = "Dialaya", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });


            //var w2 = new Week { Cycle = 1, Number = 2, StartDate = nextMonday.AddDays(7), EndDate = nextMonday.AddDays(11) };
            //w2.Add(new Village { Name = "Karaya Kofoulabé", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w2.Add(new Village { Name = "Sitantoumou", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w2.Add(new Village { Name = "Karaya Toumouba", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w2.Add(new Village { Name = "Bankoni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w2.Add(new Village { Name = "Karaya Kouroudioula", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });

            //var w3 = new Week { Cycle = 1, Number = 3, StartDate = nextMonday.AddDays(14), EndDate = nextMonday.AddDays(18) };
            //w3.Add(new Village { Name = "Sofeto", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w3.Add(new Village { Name = "Kéniékola", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w3.Add(new Village { Name = "Kouroula", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
            //w3.Add(new Village { Name = "Kofeba", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
            //w3.Add(new Village { Name = "Koré", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });

            //weeks.Add(w1);
            //weeks.Add(w2);
            //weeks.Add(w3);

            //lstView.ItemsSource = weeks;

        }

        //    private void LoadData()
        //    {
        //        villages.Add(new Village { Name = "Bendougouba", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Bendougouni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Toumbougouni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Laminila", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Dialaya", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Karaya Kofoulabé", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Sitantoumou", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Karaya Toumouba", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Bankoni", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Karaya Kouroudioula", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Sofeto", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kéniékola", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kouroula", Commune = "Bendougouba", CSCom = "Bendougouba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kofeba", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Koré", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Horongo", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Farafe", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kankoudiana-Faradala", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Fodedougou", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Sambala", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kouroukoto", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Toumoudoto", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kouyou", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kalla", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Dambana", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Nialakalan", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Massala", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Gassito", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Banfarala", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Douri", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kodianola", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Samadjikindan", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Baragna", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Tabakofe", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Sendensare", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Madila", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Nimiran", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kokounkoutou", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Faragueto", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Fatafing", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Thieourou", Commune = "Kita Ouest", CSCom = "Kofeba", District = "Kita" });
        //        villages.Add(new Village { Name = "Dafela", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Golobiladji", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Sananfara", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Makana bambara", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Goumanko", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Makana birgo", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Boro", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Gontan", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Toumoumba", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Makodji", Commune = "Badia", CSCom = "Dafela", District = "Kita" });
        //        villages.Add(new Village { Name = "Boudofo", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Kéniéroba", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Seme", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Mourdiah", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Oualia", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Dialikebafata", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Ganf Mourdiah", Commune = "Boudofo", CSCom = "Boudofo", District = "Kita" });
        //        villages.Add(new Village { Name = "Brénimba", Commune = "Boudofo", CSCom = "Brénimba", District = "Kita" });
        //        villages.Add(new Village { Name = "Kolonding", Commune = "Boudofo", CSCom = "Brénimba", District = "Kita" });
        //        villages.Add(new Village { Name = "Founia moribougou", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Kolena", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Saint Isidore", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Boubouya", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Founia birgo", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Kodogoni", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Dougna", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Diangola Kita", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Diangola birgo", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Doumba", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Faraba guimba", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Faraba niafala", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Bandiougoula", Commune = "Benkady-Founia", CSCom = "Founia Moribougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Makandiambougou", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Moribougou", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Tounkarala", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Kossilabougou", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Farabala", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Samedougou", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Niafala", Commune = "Kita", CSCom = "Makandiambougou", District = "Kita" });
        //        villages.Add(new Village { Name = "Darsalam", Commune = "Kita", CSCom = "Darsalam", District = "Kita" });
        //        villages.Add(new Village { Name = "Segoubougouni", Commune = "Kita", CSCom = "Darsalam", District = "Kita" });
        //        villages.Add(new Village { Name = "Saint-Felix", Commune = "Kita", CSCom = "Saint-Felix", District = "Kita" });
        //        villages.Add(new Village { Name = "Doumbacoura", Commune = "Kita", CSCom = "Saint-Felix", District = "Kita" });
        //        villages.Add(new Village { Name = "Djidjan", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Konitonoma Namala", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Konitonoma Noumorila", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Konitonoma Djemakana", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Kabé", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Founticouroula", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Doumbandjila", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Kassan", Commune = "Djidjan", CSCom = "Djidjan", District = "Kita" });
        //        villages.Add(new Village { Name = "Mambri", Commune = "Souranzan", CSCom = "Mambri", District = "Kita" });
        //        villages.Add(new Village { Name = "Souranzan", Commune = "Souranzan", CSCom = "Mambri", District = "Kita" });
        //        villages.Add(new Village { Name = "Souranzan dalala", Commune = "Souranzan", CSCom = "Mambri", District = "Kita" });
        //        villages.Add(new Village { Name = "Kofoulabé", Commune = "Souranzan", CSCom = "Mambri", District = "Kita" });

        //    }

        //    void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        //    {
        //        Village selectedItem = e.SelectedItem as Village;
        //    }

        //    void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        //    {
        //        villages.Remove(e.Item as Village);
        //    }


        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

        }
        void Unschedule_Clicked(object sender, EventArgs e)
        {

        }

    //    void Button_Clicked(System.Object sender, System.EventArgs e) => villages.Insert(0,
    //        new Village { Name = "Test village", Commune = "Test commune", CSCom = "Test CSCom", District = "Test district" });

    //    async void Unschedule_Clicked(object sender, EventArgs e)
    //    {
    //        MenuItem menuItem = sender as MenuItem;

    //        var village = menuItem.BindingContext as Village;
    //        var unschedule = await DisplayAlert("Unschedule village?", $"Do you want to unschedule {village.Name}?", "Yes", "No");

    //        if (unschedule)
    //        {
    //            villages.Remove(village);
    //        }
    //    }
   }
}