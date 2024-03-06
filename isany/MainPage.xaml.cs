namespace isany;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}
  
	private void BotãoVoltarFoiClicado(object sender, EventArgs args)
  {
    frameAbout.IsVisible = false;
  }
	

}

