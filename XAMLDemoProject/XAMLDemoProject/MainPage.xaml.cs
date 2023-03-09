using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMLDemoProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GreetMeButton_Clicked(object sender, EventArgs e)
        {
            string greeting = "Hello " + NameEntry.Text;
            GreetingLabel.Text = greeting;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //sliderValueLabel.Text = e.NewValue.ToString();
            sliderValueLabel.Text = ((Slider)sender).Value.ToString("F2");
        }
    }
}
