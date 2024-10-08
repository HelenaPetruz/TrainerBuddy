using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Faturamento
    {
        public int id_faturamento { get; set; }
        public int id_Usuario { get; set; }
        public int id_Plano { get; set; }
        public DateTime vencimento { get; set; }
        public DateTime data_compra {  get; set; }

        public Faturamento()
        {
        }

        public Faturamento(int id_faturamento, int id_Usuario, int id_Plano, DateTime vencimento, DateTime data_compra)
        {
            this.id_faturamento = id_faturamento;
            this.id_Usuario = id_Usuario;
            this.id_Plano = id_Plano;
            this.vencimento = vencimento;
            this.data_compra = data_compra;
        }

        public override bool Equals(object obj)
        {
            return obj is Faturamento faturamento &&
                   id_faturamento == faturamento.id_faturamento &&
                   id_Usuario == faturamento.id_Usuario &&
                   id_Plano == faturamento.id_Plano &&
                   vencimento == faturamento.vencimento &&
                   data_compra == faturamento.data_compra;
        }

        public override int GetHashCode()
        {
            int hashCode = 425352812;
            hashCode = hashCode * -1521134295 + id_faturamento.GetHashCode();
            hashCode = hashCode * -1521134295 + id_Usuario.GetHashCode();
            hashCode = hashCode * -1521134295 + id_Plano.GetHashCode();
            hashCode = hashCode * -1521134295 + vencimento.GetHashCode();
            hashCode = hashCode * -1521134295 + data_compra.GetHashCode();
            return hashCode;
        }
    }


}
