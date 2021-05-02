using System.Collections.Generic;

namespace Cadastro.De.Series.Interfaces
{
    public interface IRepositorio<t>
    {
        List<t> Lista();
        t ObterId(int id);
        void Enserir(t entidade);
        void Excluir(int id);
        void Atualizar(int id, t entidade);
        int ProximoId();
        
    }

}