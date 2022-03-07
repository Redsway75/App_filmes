namespace App_filmes.Class
{
    public abstract class EntidadeBase
    {
        protected int Id;
        public int getId(){
            return Id;
        }
        public void setId(int id){
            this.Id = id;
        }
    }
}