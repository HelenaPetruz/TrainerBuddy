using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PessoaValidation: AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(pessoa => pessoa.email).NotEmpty().WithMessage("Ops, você esqueceu de inserir seu email :(");

            RuleFor(pessoa => pessoa.email).EmailAddress().WithMessage("Ops, email inválido, tente novamente :(");

            RuleFor(pessoa => pessoa.email).MaximumLength(45).WithMessage("Ops email muito grande, tente outro :(");

            RuleFor(pessoa => pessoa.senha).NotEmpty().WithMessage("Ops, você esqueceu de inserir sua senha :(");

            RuleFor(pessoa => pessoa.senha).Length(6, 45).WithMessage("Ops senha muito curta ou longa demais, tente outra senha :(");
        }
    }
}
