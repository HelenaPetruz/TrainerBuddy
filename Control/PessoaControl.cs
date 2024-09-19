using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Control
{
     public class PessoaControl
    {
        private PessoaRepository _pessoaRepository;

        public PessoaControl()
        {
            _pessoaRepository = new PessoaRepository();
        }

        public string Update(string nome_usuario, string cpf, string email, string senha, int id_plano, int id_perfil)
        {
            var pessoa = new Pessoa
            {
                nome_usuario = nome_usuario,
                cpf = cpf,
                email = email,
                senha = senha,
                id_plano = id_plano,
                id_perfil = id_perfil,
           

            };
                return _pessoaRepository.Update(pessoa);
        }

        public string Insert(Pessoa pessoa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _pessoaRepository.Insert(pessoa);

        }
        public string Remove(int idPessoa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _pessoaRepository.Remove(idPessoa);

        }

        public DataTable getAll()
        {
            return _pessoaRepository.getAll();
        }
        public DataTable filterByName(string nome)
        {
            return _pessoaRepository.FilterByName(nome);
        }

    }
}
