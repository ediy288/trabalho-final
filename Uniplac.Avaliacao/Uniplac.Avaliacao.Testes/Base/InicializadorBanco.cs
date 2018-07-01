using System;
using System.Data.Entity;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;

namespace Uniplac.Avaliacao.Testes.Base
{
    public class InicializadorBanco<T> : DropCreateDatabaseAlways<LojaContexto>
    {

        protected override void Seed(LojaContexto context)
        {

            Cliente cliente = new Cliente();
            cliente.PrimeiroNome = "lol";
            cliente.Sobrenome = "legends";
            cliente.Cpf = "123456";
            cliente.Telefone = "(49) 9 25845545";
            cliente.DataNascimento = DateTime.Now.AddYears(-24);
            cliente.Endereco = new Endereco
            {
                Cep = "88509900",
                Logradouro = "Avenida Marechal Castelo Branco",
                Bairro = "Universitário",
                Cidade = "Lages",
                Uf = "SC",
                Numero = "123"
            };

            Veiculo veiculo = new Veiculo();
            veiculo.Marca = "suzuki";
            veiculo.Modelo = "intruder";
            veiculo.Placa = "MLI-0800";
            veiculo.Ano = 2008;
            veiculo.Chassi = "998787778xz8c";
            veiculo.Renavam = "954264521";


            Aluga aluga = new Aluga();
            aluga.Valor = 11000;
            aluga.IdCliente = cliente;
            aluga.IdVeiculo = veiculo;
            aluga.QuantDia = 3;


            context.Alugas.Add(aluga);
            //Salvar no contexto

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
