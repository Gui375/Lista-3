using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICategoriaServices
    {
        IEnumerable<CategoriaViewModel> ObterTodos();
        Task<CategoriaViewModel> ObterPorId(Guid id);
        Task<IEnumerable<CannotUnloadAppDomainException>> ObterPorCategoria(int codigo);

        void Adicionar(NovaCategoriaViewModel NovaCategoriaViewMoel);
        void Atualizar(CategoriaViewModel produto);
    }
}
