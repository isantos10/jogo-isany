namespace isany;

public partial class TerceiraPage : ContentPage
{
    public TerceiraPage()
	{
		InitializeComponent();
	}
    private void BotaoTrilhaFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new TrilhaPage();
  }
   private void BotaoCacaFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new CacaPage();
  }
}