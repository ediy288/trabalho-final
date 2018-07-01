using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Cliente
    {

     
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
   
    public string NomeCompleto
    {
        get
        {
            return String.Format("{0} {1}",
                PrimeiroNome, Sobrenome);
        }
    }

    public void Validar()
    {
        if (String.IsNullOrWhiteSpace(PrimeiroNome))
            throw new DominioException("Primeiro nome inválido!");
        if (String.IsNullOrWhiteSpace(Sobrenome))
            throw new DominioException("Sobrenome inválido!");
        if (String.IsNullOrWhiteSpace(Cpf))
             throw new DominioException("CPF inválido!");
        if (String.IsNullOrWhiteSpace(Telefone))
            throw new DominioException("Telefone inválido!");
        if (DataNascimento == new DateTime(0001, 01, 01))
            throw new DominioException("Data nascimento inválida!");
        if (Endereco == null)
            throw new DominioException("Endereço inválido!");
    }
}

}
