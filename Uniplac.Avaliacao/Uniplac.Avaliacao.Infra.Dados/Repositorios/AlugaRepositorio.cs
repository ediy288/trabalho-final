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
    public class AlugaRepositorio : IAlugaRepositorio
    {
        public LojaContexto _contexto;

        public AlugaRepositorio()
        {
            _contexto = new LojaContexto();
        }

        public void Adicionar(Aluga entidade)
        {
            _contexto.Alugas.Add(entidade);

            _contexto.SaveChanges();
        }

        public Aluga BuscarPor(int id)
        {
            return _contexto.Alugas.Find(id);
        }

        public Aluga BuscarPorValor(double valor)
        {
            return _contexto.Alugas
                .Where(p => p.Valor == valor)
                .FirstOrDefault();
        }

        public List<Aluga> BuscarTudo()
        {
            return _contexto.Alugas.ToList();
        }

        public void Deletar(Aluga entidade)
        {
            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Alugas.Attach(entidade);
            }

            _contexto.Alugas.Remove(entidade);

            _contexto.SaveChanges();
        }

        public void Editar(Aluga entidade)
        {

            DbEntityEntry dbEntityEntry = _contexto.Entry(entidade);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                _contexto.Alugas.Attach(entidade);
            }
            _contexto.SaveChanges();
        }
    }
}
