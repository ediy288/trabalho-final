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
    public class VeiculoRepositorioTeste
    {
        private LojaContexto _contextoTeste;
        private VeiculoRepositorio _repositorio;
        private Veiculo _veiculoTest;

        [TestInitialize]
        public void Inicializador()
        {

            Database.SetInitializer(new InicializadorBanco<LojaContexto>());

            _contextoTeste = new LojaContexto();

            _repositorio = new VeiculoRepositorio();

            _veiculoTest = ConstrutorObjeto.CriarVeiculo();

            _contextoTeste.Database.Initialize(true);
        }

        [TestMethod]
        public void Deveria_Adicionar_Veiculo()
        {
            _repositorio.Adicionar(_veiculoTest);

            //Afirmar
            var todosVeiculos = _contextoTeste.Veiculos.ToList();

            Assert.AreEqual(2, todosVeiculos.Count);

        }

        [TestMethod]
        public void Deveria_Editar_Veiculo()
        {
            //Preparação
            var veiculoEditado = _contextoTeste.Veiculos.Find(1);
            veiculoEditado.Marca = "EDITADO";

            //Ação
            _repositorio.Editar(veiculoEditado);

            //Afirmar
            var veiculoBuscado = _contextoTeste.Veiculos.Find(1);

            Assert.AreEqual("EDITADO", veiculoBuscado.Marca);

        }

        [TestMethod]
        public void Deveria_deletar_Veiculo()
        {
            var veiculoDeletado = _contextoTeste.Veiculos.Find(1);

            //Ação
            _repositorio.Deletar(veiculoDeletado);

            //Afirmar
            var todosVeiculos = _contextoTeste.Veiculos.ToList();

            Assert.AreEqual(0, todosVeiculos.Count);

        }

        [TestMethod]
        public void Deveria_buscar_Veiculo_por_id()
        {

      
            var veiculoBuscado = _repositorio.BuscarPor(1);

            Assert.IsNotNull(veiculoBuscado);
        }
        [TestMethod]
        public void Deveria_buscar_todos_os_Veiculos()
        {
           
            var veiculoBuscado = _repositorio.BuscarTudo();

       

            Assert.IsNotNull(veiculoBuscado);
        }
        [TestMethod]
        public void Deveria_buscar_Veiculo_por_Marca()
        {
          
            var veiculoBuscado = _repositorio.BuscarPorMarca("suzuki");

            //Afirmar

            Assert.IsNotNull(veiculoBuscado);
        }

    }
}
