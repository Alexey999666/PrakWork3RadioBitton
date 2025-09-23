
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
                num = num / 1000;
                entManusRez.Text = num.ToString();
            }
        }
        
    }
}