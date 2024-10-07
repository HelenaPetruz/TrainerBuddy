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

        public string Update(int idpessoa, string nome_usuario, string cpf, string email)
        {
            var pessoa = new Pessoa
            {
                nome_usuario = nome_usuario,
                cpf = cpf,
                email = email,
                idpessoa = idpessoa,
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

        public DataTable filterByEmail(string email)
        {
            return _pessoaRepository.FilterByEmail(email);
        }

        public string ValidaEntrada(string email, string senha)
        {
            return _pessoaRepository.ValidaEntrada(email, senha);
        }

        public string Cadastro(string email, string senha, string Repita)
        {
            return _pessoaRepository.Cadastro(email, senha, Repita);

        }

        public DataTable getUsuáriosAtivos()
        {
            return _pessoaRepository.getUsuáriosAtivos();
        }

        public string Desativar(int idpessoa)
        {
            
            return _pessoaRepository.Desativar(idpessoa);
        }

        public string Reativar(int idpessoa)
        {
            return _pessoaRepository.Reativar(idpessoa);
        }


    }
}
