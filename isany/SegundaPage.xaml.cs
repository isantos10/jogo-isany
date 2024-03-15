namespace isany;

public partial class SegundaPage : ContentPage
{


	public SegundaPage()
	{
		InitializeComponent();
	}

	private void BotaoAvancarFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new TerceiraPage();
  }
}
   