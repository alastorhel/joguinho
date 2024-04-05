namespace joguinho;

public partial class Fimjogo : ContentPage
{

    public Fimjogo()
    {	
		InitializeComponent();
    }
     private void podevoltar(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
  }

}


