using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class VeiculoTeste
    {
        private Veiculo _veiculo;

        [TestInitialize]
        public void Inicializador()
        {
            _veiculo = ConstrutorObjeto.CriarVeiculo();
        }

        [TestMethod]
        public void Veiculo_deve_ter_marca()
        {
            Assert.AreEqual("Honda",_veiculo.Marca);
        }

        [TestMethod]
        public void Veiculo_deve_ter_modelo()
        {
            Assert.AreEqual("CG", _veiculo.Modelo);
        }

        [TestMethod]
        public void Veiculo_deve_ter_Ano()
        {
            Assert.AreEqual(2018, _veiculo.Ano);
        }

        [TestMethod]
        public void Veiculo_deve_ter_placa()
        {
            Assert.AreEqual("MLM-1234", _veiculo.Placa);
        }

        [TestMethod]
        public void Veiculo_deve_ter_chassi()
        {
            Assert.AreEqual("123", _veiculo.Chassi);
        }

        [TestMethod]
        public void Veiculo_deve_ter_renavam()
        {
            Assert.AreEqual("12345", _veiculo.Renavam);
        }



        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_marca()
        {
            _veiculo.Marca = "";

            _veiculo.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_modelo()
        {
            _veiculo.Modelo = "";

            _veiculo.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_ano()
        {
            _veiculo.Ano = -1;

            _veiculo.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_placa()
        {
            _veiculo.Placa = "";

            _veiculo.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_chassi()
        {
            _veiculo.Chassi = "";

            _veiculo.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Cliente_deve_validar_renavam()
        {
            _veiculo.Renavam = "";

            _veiculo.Validar();
        }






    }
}
