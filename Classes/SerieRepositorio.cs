using System;
using System.Collections.Generic;
using Cadastro.De.Series.Interfaces;


namespace Cadastro.De.Series
{
    public class SerieRepositorio : IRepositorio<Serie> 
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade){}
    
        public Serie ObterId(int id)
        {
            return ListaSerie[id];
        }

        public void Enserir(Serie entidade)
        {
            ListaSerie.Add(entidade);

        }

        public void Atualizar(int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {

            Serie obj = new Serie();
            obj.exclui();
            ListaSerie[id] = obj;
        }
 
        public List<Serie> Lista()
        {
            return ListaSerie;
        }


        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        internal object getId(object indice_Serie)
        {
            throw new NotImplementedException();
        }
    }
    
}