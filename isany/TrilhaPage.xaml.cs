namespace isany;

public partial class TrilhaPage : ContentPage
{
    public TrilhaPage()
	{
		InitializeComponent();
	}
	 private void BotaoFinalizarFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new FinalizarPage();
  }
}