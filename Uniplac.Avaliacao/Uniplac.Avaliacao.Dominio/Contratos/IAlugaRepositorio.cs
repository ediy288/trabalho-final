using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Entidades;

namespace Uniplac.Avaliacao.Dominio.Contratos
{
   public interface IAlugaRepositorio : IRepositorio<Aluga>
    {
        Aluga BuscarPorValor(double valor);

    }
}

