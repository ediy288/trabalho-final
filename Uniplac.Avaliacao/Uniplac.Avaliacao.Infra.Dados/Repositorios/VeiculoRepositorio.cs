using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.Avaliacao.Dominio.Contratos;
using Uniplac.Avaliacao.Dominio.Entidades;
using Uniplac.Avaliacao.Infra.Dados.Contexto;

namespace Uniplac.Avaliacao.Infra.Dados.Repositorios
{
   public class VeiculoRepositorio : IVeiculoRepositorio
    {
        public LojaContexto _contexto;
        public VeiculoRepositorio()
        {
            _contexto = new LojaContexto();
        }

        public void Adicionar(Veiculo entidade)
        {
            _contexto.Veiculos.Add(entidade);

            _contexto.SaveChanges();
        }

        public Veiculo BuscarPor(int id)
        {
            return _contexto.Veiculos.Find(id);
        }

        public Veiculo BuscarPorMarca(string nome)
        {
            return _contexto.Veiculos
           .Where(p => p.Marca == nome)
           .FirstOrDefault();
        }

        public List<Veiculo> BuscarTudo()
        {
            return _contexto.Veiculos.ToList();
        }

        public void Deletar(Veiculo entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Veiculos.Attach(entidade);
            }

            _contexto.Veiculos.Remove(entidade);

            _contexto.SaveChanges();
        }

        public void Editar(Veiculo entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Veiculos.Attach(entidade);
            }

            _contexto.SaveChanges();
        }
    }
}
