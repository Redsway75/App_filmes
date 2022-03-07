using System;
using System.Collections.Generic;
using App_filmes.Interface;

namespace App_filmes.Class

{
    public class SeriesRepositorio : Irepositorio<Series>
    {
        private List<Series> ListaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].exclui();
        }

        public void Insere(Series entidade)
        {
            ListaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return ListaSerie;
        }

        public int Proximo()
        {
           return ListaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}