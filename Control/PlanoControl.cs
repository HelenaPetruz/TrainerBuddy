using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class PlanoControl
    {
        private PlanoRepository _planoRepository;

        public PlanoControl()
        {
            _planoRepository = new PlanoRepository();
        }

        public string Update(string nome_plano, double valor)
        {
            var plano = new Plano
            {
                nome_plano = nome_plano,
                valor = valor
            };
            return _planoRepository.Update(plano);
        }

        public string Insert(Plano plano)
        {
            return _planoRepository.Insert(plano);
        }

        public string Remove(int id_plano)
        {
            return _planoRepository.Remove(id_plano);
        }

        public DataTable getAll() 
        { 
            return _planoRepository.getAll();
        }

        public DataTable filterByName( string nome_plano)
        {
            return _planoRepository.FilterByName(nome_plano);
        }




    }
}
