using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Aluga
    {
        public int Id { get; set; }
        public virtual Veiculo IdVeiculo { get; set; }
        public virtual Cliente IdCliente { get; set; }
        public double Valor { get; set; }
        public int QuantDia { get; set; }

        public void Validar()
        {
            if (IdCliente == null)
                throw new DominioException("Cliente inválido!");
            if (IdVeiculo == null)
                throw new DominioException("Veiculo inválido!");
            if (Valor < 0)
                throw new DominioException("Ano inválido!");
            if (QuantDia < 0)
                throw new DominioException("Quantidade dias inválido!");
        }
    }

}
