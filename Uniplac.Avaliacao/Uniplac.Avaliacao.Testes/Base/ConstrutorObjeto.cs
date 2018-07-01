using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;

namespace Uniplac.Avaliacao.Testes.Base
{
  public  class ConstrutorObjeto
    {

        public static Cliente CriarCliente()
        {
            return new Cliente
            {
                Id = 1,
                PrimeiroNome = "ediy",
                Sobrenome = "perin",
                Cpf = "123456",
                Telefone = "(49) 99988-7766",
                DataNascimento = new DateTime(1998, 09, 29),
                Endereco = new Endereco
                {
                    Numero = "488",
                    Logradouro = "joao branco",
                    Bairro = "sagrado",
                    Cidade = "Lages",
                    Uf = "SC",
                    Cep = "88 777 666"
                    
                },
            };
        }

        public static Veiculo CriarVeiculo()
        {
            return new Veiculo
            {
                Id = 1,
                Marca = "Honda",
                Modelo = "CG",
                Ano = 2018,
                Placa = "MLM-1234",
                Chassi = "123",
                Renavam ="12345"

            };
        }


        public static Aluga CriarAluguel()
        {
            return new Aluga
            {
                Id = 1,
                IdVeiculo = CriarVeiculo(),
                IdCliente = CriarCliente(),
                Valor = 10000.50,
                QuantDia = 7

            };
        }

    }
}
