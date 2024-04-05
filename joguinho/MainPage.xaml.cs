namespace joguinho;

public partial class MainPage : ContentPage
{
	
    Lin lin; Sofie sofie; Triel triel; Pai atual;

   public MainPage()
    {
        InitializeComponent();
        lin = new  Lin();
        sofie = new Sofie();
        triel = new Triel();
        atual = lin;
        programa.Source = atual.GetArquivo();
        AtualizaPersonagem();

         var timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (s,e) => PassouTempo();
        timer.Start();
    }

    //----------

     void AtualizaPersonagem()
     {

        sede.Progress = atual.GetSede();
        fome.Progress = atual.GetFome();
        carinho.Progress = atual.GetCarinho();
     }


     void PassouTempo()
     {
       lin.SetFome(lin.GetFome()-0.02);
       lin.SetSede(lin.GetSede()-0.02);
       lin.SetCarinho(lin.GetCarinho()-0.02);

       sofie.SetFome(sofie.GetFome()-0.02);
       sofie.SetSede(sofie.GetSede()-0.02);
       sofie.SetCarinho(sofie.GetCarinho()-0.02);

       triel.SetFome(triel.GetFome()-0.02);
       triel.SetSede(triel.GetSede()-0.02);
       triel.SetCarinho(triel.GetCarinho()-0.02);

        AtualizaPersonagem();
     }

    void aflecha(object sender,EventArgs args)
    {
        if (atual == lin)
            atual = sofie;
        else if (atual == sofie)
            atual = triel;
        else if (atual == triel)
            atual = lin;
        programa.Source = atual.GetArquivo();
        AtualizaPersonagem();
    }

    void ocarinho(object sender,EventArgs args)
    {
        atual.SetCarinho(atual.GetCarinho()+0.5);
        carinho.Progress = atual.GetCarinho();
    }

    void oservo(object sender,EventArgs args)
    {
        atual.SetFome(atual.GetFome()+0.5);
        fome.Progress = atual.GetFome();
    }

    void aagua(object sender,EventArgs args)
    {
        atual.SetSede(atual.GetSede()+0.5);
        sede.Progress = atual.GetSede();
    }

}
