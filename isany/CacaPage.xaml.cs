namespace isany;

public partial class CacaPage : ContentPage
{
    public CacaPage()
	{
		InitializeComponent();
	}
	 private void BotaoFinalCacaFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new FinalizarPage();
  }
}
