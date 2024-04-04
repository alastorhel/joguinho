namespace joguinho;

public class Pai 
{
    protected  double fome;
     protected  double sede;
      protected  double carinho;
      protected string arquivo;
      
      public string GetArquivo()
      {
          return arquivo;
      }
      public Pai()
    {
        fome = 0;
        sede = 0;
        carinho = 0;
        
    }

    public void SetFome(double f)
    {
       
        if (f <= 1 && f >= 0)
         fome = f;
        else if (f > 1)
         fome = 1;
        else
        {
           fome = 0;
           Application.Current.MainPage=new Fimjogo();
        }
         
    
    }
     
     public double GetFome()
     {
        return sede;
     }


      public void SetSede(double s)
    {
       
        if (s <= 1 && s >= 0)
         sede = s;
        else if (s > 1)
         sede = 1;
        else
         {
           sede = 0;
           Application.Current.MainPage=new Fimjogo();
        }
    
    }
     
     public double GetSede()
     {
        return sede;
     }

      public void SetCarinho(double c)
    {
       
        if (c <= 1 && c >= 0)
         carinho = c;
        else if (c > 1)
         carinho = 1;
        else
         {
           carinho = 0;
           Application.Current.MainPage=new Fimjogo();
        }
    }
     
     public double GetCarinho()
     {
        return carinho;
     }
}

