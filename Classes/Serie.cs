using System;
using Cadastro.De.Series.Interfaces;
using Cadastro.De.Series.Lista;


namespace Cadastro.De.Series
{
    public class Serie : BaseConteudo
    {

        public Serie(int id, Genero genero, string titulo, int ano, string descricao)
        {

        }

        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;

        }
        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }
        private bool excluido { get; set;}

        public Serie(int _id, Genero _genero, string _titulo, string _descricao, int _ano)
        {
            this.id = _id;
            this.genero = _genero;
            this.titulo = _titulo;
            this.descricao = _descricao;
            this.ano = _ano;
            this.excluido = false;

        }

        public Serie()
        {
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id: " + this.id + Environment.NewLine;
            retorno += "Genero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.titulo + Environment.NewLine;
            retorno += "Descricao: " + this.descricao + Environment.NewLine;
            retorno += "Ano de inicio: " + this.ano + Environment.NewLine;
            retorno += "Excluido: " + this.excluido;
            return retorno;
        }

        public int getId()
        {
            return this.id;
        }

        public object getGenero()
        {
            return this.genero;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public int getAno()
        {
            return this.ano;
        }

        public bool getExcluido()
        {
            return this.excluido;
        }

        public void exclui()
        {
            this.excluido = true;
        }
    }

}