using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cond_pagamento
    {
        public int id_cond_pagamento {  get; set; }
        public string numero_de_conta { get; set; }
        public string nome { get; set; }
        public int id_plano { get;set; }

        public Cond_pagamento()
        {
        }

        public Cond_pagamento(int id_cond_pagamento, string numero_de_conta, string nome, int id_plano)
        {
            this.id_cond_pagamento = id_cond_pagamento;
            this.numero_de_conta = numero_de_conta;
            this.nome = nome;
            this.id_plano = id_plano;
        }

        public override bool Equals(object obj)
        {
            return obj is Cond_pagamento pagamento &&
                   id_cond_pagamento == pagamento.id_cond_pagamento &&
                   numero_de_conta == pagamento.numero_de_conta &&
                   nome == pagamento.nome &&
                   id_plano == pagamento.id_plano;
        }

        public override int GetHashCode()
        {
            int hashCode = 1106968310;
            hashCode = hashCode * -1521134295 + id_cond_pagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(numero_de_conta);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + id_plano.GetHashCode();
            return hashCode;
        }
    }
}
