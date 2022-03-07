namespace App_filmes.Class
{
    public class Series:EntidadeBase
    {
        private Genero Genero;

        private String Titulo;

        private String Descricao;

        private int Ano;

        private bool Excluido {get; set;}

        public Series(int id, Genero genero, String titulo, String descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        //____________________________________________________________________________

        public Genero GetGenero(){return Genero;}
        public void SetGenero(Genero genero){this.Genero = genero;}

        public String GetTitulo(){return Titulo;}
        public void SetTitulo(String titulo){this.Titulo = titulo;}

        public String GetDescricao(){return Descricao;}
        public void SetDescricao(String descricao){this.Descricao = descricao;}
        //___________________________________________________________________________________

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano: "+ this.Ano + Environment.NewLine;
            return retorno;
        }

        public String retornaTitulo(){return this.Titulo;}
        public int retornaId(){return this.Id;}

        public bool retornaIdExcluido(){
            return this.Excluido;
        }

        public void exclui(){this.Excluido = true;}

    }
}