using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double h = Double.Parse(height.Text);
            Double w = Double.Parse(weight.Text);

            DisplayAlert("伸長",h.ToString(), "OK");
            DisplayAlert("体重",w.ToString(), "OK");
            if(h>=3)
            {
                h /= 100;
            }
            double bmi = w / h / h;
           // DisplayAlert("BMI".bmi.to'OK');

        }
    }
}
