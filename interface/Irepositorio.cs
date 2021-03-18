using System.Collections.Generic;
namespace LAN.series.interface
{
    public interface Irepositorio<t>
    {
      List<T>Lista();
      T RetornaPorId(int Id);
      void Insere(T entidade);
      void Exclui(int id);
      void Atualiza(int id T entidade);
      int ProximoId();
    }
}