
using System.Diagnostics.Metrics;

namespace PrakWork3RadioBitton;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    

    private void tgldOnOffManus_Toggled(object sender, ToggledEventArgs e)
    {
        if(slManus.IsEnabled == false)
        {
            slManus.IsEnabled = true;
        }
        else slManus.IsEnabled = false;
    }

    private void btnManusRez_Clicked(object sender, EventArgs e)
    {
        double num;
        if(double.TryParse(entManusEnter.Text, out num) )
        {
            if (rbManusKilo.IsChecked == true)
            {
                double Kilo = num * 1000;
               
                entManusRez.Text = Kilo.ToString();
                
            }
            else if (rbManusMetr.IsChecked == true)
            {
                double metr = num;
                entManusRez.Text = metr.ToString();
                
            }
            else if(rbManusDeci.IsChecked == true) 
            {
                double deci = num / 10;
                entManusRez.Text = deci.ToString();
            }
            else if(rbManusSanti.IsChecked == true)
            {
                double santi = num / 100;
                entManusRez.Text = santi.ToString();
            }
            else if(rbManusMilli.IsChecked == true)
            {
                double milli = num / 1000;
                entManusRez.Text = milli.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entManusRez.Text = error.ToString();
        }
            
    }

    private void tcentManusEnter(object sender, TextChangedEventArgs e)
    {
        entManusRez.Text = "";
    }

    private async void btnSwitchBack_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}