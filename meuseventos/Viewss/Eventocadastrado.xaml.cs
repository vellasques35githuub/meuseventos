namespace meuseventos.Viewss;

public partial class Eventocadastrado : ContentPage
{
	public Eventocadastrado()
	{
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}

    }
}