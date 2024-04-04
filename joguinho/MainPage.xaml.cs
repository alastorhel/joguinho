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
        carinho.Progress = atual.GetCarinho();
    }

    void ocarinho(object sender,EventArgs args)
    {
        atual.SetCarinho(atual.GetCarinho()+0.1);
        carinho.Progress = atual.GetCarinho();
    }

    void oservo(object sender,EventArgs args)
    {
        atual.SetFome(atual.GetFome()+0.1);
        comida.Progress = atual.GetFome();
    }

    void aagua(object sender,EventArgs args)
    {
        atual.SetSede(atual.GetSede()+0.1);
        sede.Progress = atual.GetSede();
    }

}
