using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Cond_pagamentoControl
    {
        private Cond_pagamentoRepository _cond_pagamentoRepository;

        public Cond_pagamentoControl(Cond_pagamentoRepository cond_pagamentoRepository)
        {
            _cond_pagamentoRepository = cond_pagamentoRepository;
        }

        public string Update(int id_cond_pagamento, string numero_de_conta, string nome, int id_plano)
        {
            var Cond_pagamento = new Cond_pagamento
            {
                id_cond_pagamento = id_cond_pagamento,
                numero_de_conta = numero_de_conta,
                nome = nome,
                id_plano = id_plano,
            };

            return _cond_pagamentoRepository.Update(Cond_pagamento);
        }
        public string Insert(Cond_pagamento Cond_pagamento)
        {
            return _cond_pagamentoRepository.Insert(Cond_pagamento);
        }

        public string Remove(int id_cond_pagamento)
        {
            return _cond_pagamentoRepository.Remove(id_cond_pagamento);
        }

        public DataTable getAll()
        {
            return _cond_pagamentoRepository.getAll();
        }

        public DataTable filterByName(string nome)
        {
            return _cond_pagamentoRepository.FilterByName(nome);
        }
    }

   
}
