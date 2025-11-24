namespace PrakWork3RadioBitton
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSwitchTab_Click(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Program");
        }

        async private void btnInfo_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Информация", "Андрианов Алексей ИСП-41 Вариант 14 Составить программу, которая бы по значению переменной Х, означающему некоторую длину в следующих единицах измерения: дециметр, километр, метр, миллиметр, сантиметр; выдавала бы эту длину в метрах.", "OK");
        }
    }

}
