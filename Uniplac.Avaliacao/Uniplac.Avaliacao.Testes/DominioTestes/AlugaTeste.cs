using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Dominio.Excecoes;
using Uniplac.Avaliacao.Testes.Base;

namespace Uniplac.Avaliacao.Testes.DominioTestes
{
    [TestClass]
    public class AlugaTeste
    {
        private Aluga _aluga;

        [TestInitialize]

        public void Inicializador()
        {
            _aluga = ConstrutorObjeto.CriarAluguel();
        }

        [TestMethod]
        public void Aluga_deve_ter_id_Cliente()
        {
            Assert.IsNotNull(_aluga.IdCliente);
        }
        [TestMethod]
        public void Aluga_deve_ter_id_Veiculo()
        {
            Assert.IsNotNull(_aluga.IdVeiculo);
        }
        [TestMethod]
        public void Aluga_deve_ter_valor()
        {
            Assert.AreEqual(10000.50, _aluga.Valor);
        }
        [TestMethod]
        public void Aluga_deve_ter_quantidade_dias()
        {
            Assert.AreEqual(7, _aluga.QuantDia);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Aluga_deve_validar_id_Cliente()
        {
            _aluga.IdCliente = null;

            _aluga.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Aluga_deve_validar_id_Veiculo()
        {
            _aluga.IdVeiculo = null;

            _aluga.Validar();
        }
        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Aluga_deve_validar_valor()
        {
            _aluga.Valor = -1;

            _aluga.Validar();
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void Aluga_deve_validar_quantidade_dias()
        {
            _aluga.QuantDia = -1;

            _aluga.Validar();
        }

    }
}
