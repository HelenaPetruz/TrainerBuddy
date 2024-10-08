using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Plano
    {
        public int id_plano {  get; set; }
        public string nome_plano { get; set; }
        public double valor {  get; set; }

        public Plano()
        {
        }

        public Plano(int id_plano, string nome_plano, double valor)
        {
            this.id_plano = id_plano;
            this.nome_plano = nome_plano;
            this.valor = valor;
        }

        public override bool Equals(object obj)
        {
            return obj is Plano plano &&
                   id_plano == plano.id_plano &&
                   nome_plano == plano.nome_plano &&
                   valor == plano.valor;
        }

        public override int GetHashCode()
        {
            int hashCode = -519809929;
            hashCode = hashCode * -1521134295 + id_plano.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome_plano);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            return hashCode;
        }
    }
}
