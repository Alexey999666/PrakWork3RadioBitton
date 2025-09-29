namespace PrakWork3RadioBitton;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void tgldOnOffAuto_Toggled(object sender, ToggledEventArgs e)
    {
        if (slAuto.IsEnabled == false)
        {
            slAuto.IsEnabled = true;
        }
        else slAuto.IsEnabled = false;
    }

    private void ccrbAutoKilo(object sender, CheckedChangedEventArgs e)
    {
        if(rbAutoKilo.IsChecked == true)
        {
            double num;
            if (double.TryParse(entAutoEnter.Text, out num))
            {
                double Kilo = num * 1000;

                entAutoRez.Text = Kilo.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entAutoRez.Text = error.ToString();
        }
    }

    private void entAutoEnter_TextChanged(object sender, TextChangedEventArgs e)
    {
        entAutoRez.Text = "";
    }

    private void ccrbAutoMetr(object sender, CheckedChangedEventArgs e)
    {
        if (rbAutoMetr.IsChecked == true)
        {
            double num;
            if (double.TryParse(entAutoEnter.Text, out num))
            {
                double metr = num;

                entAutoRez.Text = metr.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entAutoRez.Text = error.ToString();
        }
    }
    

    private void ccrbAutoDeci(object sender, CheckedChangedEventArgs e)
    {
        if (rbAutoDeci.IsChecked == true)
        {
            double num;
            if (double.TryParse(entAutoEnter.Text, out num))
            {
                double deci = num / 10;

                entAutoRez.Text = deci.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entAutoRez.Text = error.ToString();
        }
    }

    private void ccrbAutoSanti(object sender, CheckedChangedEventArgs e)
    {
        if (rbAutoSanti.IsChecked == true)
        {
            double num;
            if (double.TryParse(entAutoEnter.Text, out num))
            {
                double santi = num / 100;

                entAutoRez.Text = santi.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entAutoRez.Text = error.ToString();
        }
    }

    private void ccrbAutoMilli(object sender, CheckedChangedEventArgs e)
    {
        if (rbAutoMilli.IsChecked == true)
        {
            double num;
            if (double.TryParse(entAutoEnter.Text, out num))
            {
                double milli = num / 1000;

                entAutoRez.Text = milli.ToString();
            }
        }
        else
        {
            string error = "ERROR";
            entAutoRez.Text = error.ToString();
        }
    }

    private async void btnSwitchBack_Click(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}