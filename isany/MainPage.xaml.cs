namespace isany;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}
	private void BotãoSobreFoiClicado(object sender, EventArgs args)
  {
	frameSobre.IsVisible=true;
  }
	private void BotãoVoltarFoiClicado(object sender, EventArgs args)
  {
    frameSobre.IsVisible = false;
  }
	private void BotãoIniciarFoiClicado(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new IsaPage();
  }

}

