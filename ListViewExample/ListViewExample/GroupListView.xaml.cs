using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupListView : ContentPage
    {
        private ObservableCollection<GroupedCarModel> grouped { get; set; }
        public GroupListView()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedCarModel>();
            var CarGroup = new GroupedCarModel() { LongName = "cars", ShortName = "v" };
            var MotobikeGroup = new GroupedCarModel() { LongName = "motor", ShortName = "f" };
            CarGroup.Add(new CarModel() { Name = "nissan", car_or_motorbike = true, Comment = "Buen diseño" });
            CarGroup.Add(new CarModel() { Name = "toyota", car_or_motorbike = true, Comment = "Buena calidad" });
            MotobikeGroup.Add(new CarModel() { Name = "Honda XR", car_or_motorbike = false, Comment = "Buena marca" });
            MotobikeGroup.Add(new CarModel() { Name = "Yamaha", car_or_motorbike = false, Comment = "Calidad" });
            grouped.Add(CarGroup); grouped.Add(MotobikeGroup);
            lstView.ItemsSource = grouped;
        }
    }
}