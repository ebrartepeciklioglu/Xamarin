using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExample1
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonName_OnClicked(object sender,EventArgs e)
        {

            string text = MainNameEntry.Text;

            MainNameLabel.Text = "Hello" +" "+ text;
        }
    }
}
