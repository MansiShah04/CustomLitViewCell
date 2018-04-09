using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewCell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listTemp.ItemsSource = new List<string>(new List<string> { "1","2","3","4","5"});
        }

    }
}
