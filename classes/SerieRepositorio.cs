using System;
using System.Collections.Generic;
using Lan.Series.Interface;

namespace LAN.series
{
    public class SerieRepositorio : Irepositorio<series>
    {
      private List<Serie>listaSerie = new List<Serie>();
      public void Atualiza(int,id,serie objeto) 
      {
          listaSerie[id] = objeto;
      }
      {
          throw new NotImplementedException();
      }
      public void Exclui(int id)
      {
          listaSerie[ID].Excluir();
      }
      public void Insere(Serie objeto)
      {
          listaSerie Add(objeto);
      }
      public List<serie>Lista()
      {
          return listaSerie;  
      }
      public int ProximoId()
      {
          return listaSerie.Count;
      }
      public Serie RetornaPorId(int id)
      {
          return listaSerie[id];
      } 
    }
}