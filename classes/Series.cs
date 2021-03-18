namespace LAN.series
{
    public class Series : EntidadeBase
    {
      //atributos
      private Genero Genero {get;set;}
      private string Titulo {get;set;}
      private string Descricao {get;set;}
      private int Ano {get;set;}
      private bool Excluido{get;set;}
        
      //metodos
      public Serie(int id,Genero genero,string titulo,string descricao,int ano)
      {
          this.Id = id;
          this.Genero = genero;
          this.Titulo = titulo;
          this.Descriçao = descricao;
          this.Ano = ano;
          this.Excluido = false;
      }
      public override ToString()
      {
          string retorno = "";
          retorno += "Genero: " + this.Genero + Environment.NewLine;
          retorno += "Titulo: " + this.Titulo + Environment.NewLine;
          retorno += "Descriçao: " + this.Descricao + Environment.NewLine;
          retorno += "Ano de inicio: " + this.Ano;
          return retorno;
      }
      public string retornaTitulo()
      {
          return this.Titulo;
      }
      public internal intretornaId()
      {
          return this.Id;
      }
      public void Excluir()
      {
          this.Excluido = true;
      }






      
    }
}