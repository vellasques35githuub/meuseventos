using meuseventos.Modelss;

namespace meuseventos.Viewss;

public partial class Cadastrodoevento : ContentPage
{
	App PropriedadesApp;
	public Cadastrodoevento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_evento.ItemsSource = PropriedadesApp.lista_eventoos;

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(6);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			Tipos h = new Tipos
			{
				EventoSelecionado = (Eventoo)pck_evento.SelectedItem,
				QntHomens = Convert.ToInt32(stp_homens.Value),
				QntMulheres = Convert.ToInt32(stp_mulheres.Value),
				DataInicio = dtpck_inicio.Date,
				DataTermino = dtpck_termino.Date,
				NomeEvento = Convert.ToString(txt_nome.GetValue),
				NumeroEvento = Convert.ToInt32(txt_numero.GetValue),
				LocalEvento = Convert.ToString(txt_local.GetValue),
				CustoEvento = Convert.ToDouble(txt_Custo.GetValue),

			};

			await Navigation.PushAsync(new Eventocadastrado()
			{
				BindingContext = h
			});

		} catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(6);
    }
}