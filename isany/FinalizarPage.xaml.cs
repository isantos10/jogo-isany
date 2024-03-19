namespace isany;

public partial class FinalizarPage : ContentPage
{
    public FinalizarPage()
	{
		InitializeComponent();
	}
	 private void BotaoFinalFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new MainPage();
  }
}