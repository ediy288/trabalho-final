using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class ClienteTeste
    {

        private Cliente _cliente;

        [TestInitialize]
        public void Inicializador()
        {
            _cliente = ConstrutorObjeto.CriarCliente();
        }
        [TestMethod]
        public void Cliente_deve_ter_primeiro_nome()
        {
            Assert.AreEqual("ediy", _cliente.PrimeiroNome);
        }
        [TestMethod]
        public void Cliente_deve_ter_sobrenome()
        {
            Assert.AreEqual("perin", _cliente.Sobrenome);
        }
        [TestMethod]
        public void Cliente_deve_ter_nome_completo()
        {
            Assert.AreEqual("ediy perin", _cliente.NomeCompleto);
        }
        [TestMethod]
        public void Cliente_deve_ter_CPF()
        {
            Assert.AreEqual("123456", _cliente.Cpf);
        }
        [TestMethod]
        public void Cliente_deve_ter_telefone()
        {
            Assert.AreEqual("(49) 99988-7766", _cliente.Telefone);
        }
        [TestMethod]
        public void Cliente_deve_ter_data_nacimento()
        {
            Assert.AreEqual(new DateTime(1998, 09, 29), _cliente.DataNascimento);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_numero()
        {
            Assert.AreEqual("488", _cliente.Endereco.Numero);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_logradouro()
        {
            Assert.AreEqual("joao branco", _cliente.Endereco.Logradouro);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_bairro()
        {
            Assert.AreEqual("sagrado", _cliente.Endereco.Bairro);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_cidade()
        {
            Assert.AreEqual("Lages", _cliente.Endereco.Cidade);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_Uf()
        {
            Assert.AreEqual("SC", _cliente.Endereco.Uf);
        }
        [TestMethod]
        public void Cliente_deve_ter_Endereco_cep()
        {
            Assert.AreEqual("88 777 666", _cliente.Endereco.Cep);
        }


        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_primeiro_nome()
        {
            _cliente.PrimeiroNome = "";

            _cliente.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_sobrenome()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.Sobrenome = "";

            _cliente.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_cpf()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.Cpf = "";

            _cliente.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_telefone()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.Telefone = "";

            _cliente.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_endereco()
        {
            var _cliente = ConstrutorObjeto.CriarCliente();

            _cliente.Endereco = null;

            _cliente.Validar();
        }

    }
}
