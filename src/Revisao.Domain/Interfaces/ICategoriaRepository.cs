using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterTodos();
        Task<Categoria> ObterPorId(Guid id);
        Task<IEnumerable<Categoria>> ObterPorCategoria(int codigo);
        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);
    }
}
