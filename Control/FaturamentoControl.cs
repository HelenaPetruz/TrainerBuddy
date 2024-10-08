using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class FaturamentoControl
    {
        private FaturamentoRepository _faturamentoRepository;

        public FaturamentoControl(FaturamentoRepository faturamentoRepository)
        {
            _faturamentoRepository = faturamentoRepository;
        }

        public string Update(int id_Usuario, int id_Plano, DateTime vencimento, DateTime data_compra)
        {
            var faturamento = new Faturamento
            {
                id_Usuario = id_Usuario,
                id_Plano = id_Plano,
                vencimento = vencimento,
                data_compra = data_compra,
            };
            return _faturamentoRepository.Update(faturamento);
        }


        public string Insert(Faturamento faturamento)
        {
            return _faturamentoRepository.Insert(faturamento);

        }

        public string Remove (int id_faturamento)
        {
            return _faturamentoRepository.Remove(id_faturamento);
        }

        public DataTable getAll()
        {
            return _faturamentoRepository.getAll();
        }
    }
}
