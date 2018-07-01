using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Excecoes;

namespace Uniplac.Avaliacao.Dominio.Entidades
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public int Id { get; set; }

        public void Validar()
        {
            if (String.IsNullOrWhiteSpace(Marca))
                throw new DominioException("Marca inválido!");
            if (String.IsNullOrWhiteSpace(Modelo))
                throw new DominioException("Modelo inválido!");
            if (String.IsNullOrWhiteSpace(Placa))
                throw new DominioException("Placa inválida!");
            if (String.IsNullOrWhiteSpace(Chassi))
                throw new DominioException("Chassi inválido!");
            if (String.IsNullOrWhiteSpace(Renavam))
                throw new DominioException("Renavam inválido!");
            if(Ano < 0)
                throw new DominioException("Ano inválido!");

        }
    }
}
