using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;
using Uniplac.Avaliacao.Infra.Dados.Repositorios;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.InfraTestes
{
    [TestClass]
    public class ClienteRepositorioTeste
    {

        private LojaContexto _contextoTeste;
        private ClienteRepositorio _repositorio;
        private Cliente _clienteTest;

        [TestInitialize]
        public void Inicializador()
        {

            Database.SetInitializer(new InicializadorBanco<LojaContexto>());

            _contextoTeste = new LojaContexto();

            _repositorio = new ClienteRepositorio();

            _clienteTest = ConstrutorObjeto.CriarCliente();

            _contextoTeste.Database.Initialize(true);
        }

        [TestMethod]
        public void Deveria_adicionar_um_novo_cliente()
        {
            //Preparação

            //Ação
            _repositorio.Adicionar(_clienteTest);

            //Afirmar
            var todosClientes = _contextoTeste.Clientes.ToList();

            Assert.AreEqual(2, todosClientes.Count);
        }

        [TestMethod]
        public void Deveria_editar_um_cliente()
        {
            //Preparação
            var clienteEditado = _contextoTeste.Clientes.Find(1);
            clienteEditado.PrimeiroNome = "EDITADO";

            //Ação
            _repositorio.Editar(clienteEditado);

            //Afirmar
            var clienteBuscado = _contextoTeste.Clientes.Find(1);

            Assert.AreEqual("EDITADO", clienteBuscado.PrimeiroNome);
        }


        [TestMethod]
        public void Deveria_deletar_um_cliente()
        {
            //Preparação
            var clienteDeletado = _contextoTeste.Clientes.Find(1);

            //Ação
            _repositorio.Deletar(clienteDeletado);

            //Afirmar
            var todosClientes = _contextoTeste.Clientes.ToList();

            Assert.AreEqual(0, todosClientes.Count);
        }

        [TestMethod]
        public void Deveria_buscar_cliente_por_id()
        {

            //Preparação

            //Ação
            var clienteBuscado = _repositorio.BuscarPor(1);

            //Afirmar

            Assert.IsNotNull(clienteBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_todos_os_clientes()
        {
            //Preparação

            //Ação
            var clienteBuscado = _repositorio.BuscarTudo();

            //Afirmar

            Assert.IsNotNull(clienteBuscado);
        }

        [TestMethod]
        public void Deveria_buscar_cliente_por_nome()
        {
            //Preparação

            //Ação
            var clienteBuscado = _repositorio.BuscarPorNome("lol");

            //Afirmar

            Assert.IsNotNull(clienteBuscado);
        }

    }
}

