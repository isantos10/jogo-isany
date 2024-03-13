namespace isany;

public partial class IsaPage : ContentPage
{


	public IsaPage()
	{
		InitializeComponent();
	}
 
 private void BotaoAvancarFoiClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new SegundaPage();
  }
} 