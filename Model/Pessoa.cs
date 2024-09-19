using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public int idpessoa { get; set; } 
        public string nome_usuario { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int id_plano { get; set; }
        public int id_perfil { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int idpessoa, string nome_usuario, string cpf, string email, string senha, int id_plano, int id_perfil)
        {
            this.idpessoa = idpessoa;
            this.nome_usuario = nome_usuario;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
            this.id_plano = id_plano;
            this.id_perfil = id_perfil;
        }

        public override bool Equals(object obj)
        {
            return obj is Pessoa pessoa &&
                   idpessoa == pessoa.idpessoa &&
                   nome_usuario == pessoa.nome_usuario &&
                   cpf == pessoa.cpf &&
                   email == pessoa.email &&
                   senha == pessoa.senha &&
                   id_plano == pessoa.id_plano &&
                   id_perfil == pessoa.id_perfil;
        }

        public override int GetHashCode()
        {
            int hashCode = 723805467;
            hashCode = hashCode * -1521134295 + idpessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome_usuario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(senha);
            hashCode = hashCode * -1521134295 + id_plano.GetHashCode();
            hashCode = hashCode * -1521134295 + id_perfil.GetHashCode();
            return hashCode;
        }
    }
}
