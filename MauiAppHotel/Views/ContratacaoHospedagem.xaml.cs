namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = ((DateTime)dtpck_checkin.Date).AddDays(1);
		dtpck_checkout.MaximumDate = ((DateTime)dtpck_checkin.Date).AddMonths(6);
	}
	private async void Avancar_Cliked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HospedagemContratada());
	}

    private async void Sobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = (DateTime)elemento.Date;

		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}