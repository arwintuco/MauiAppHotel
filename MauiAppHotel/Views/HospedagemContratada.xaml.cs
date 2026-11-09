namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}

		await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}