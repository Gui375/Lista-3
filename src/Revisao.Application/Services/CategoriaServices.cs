using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private IMapper _mapper;
        public CategoriaServices(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;   
        }
        public void Adicionar(NovaCategoriaViewModel NovaCategoriaViewMoel)
        {
            var NovaCategoria = _mapper.Map<Categoria>(NovaCategoriaViewMoel);
            _categoriaRepository.Adicionar(NovaCategoria);
        }

        public void Atualizar(CategoriaViewModel produto)
        {
            throw new NotImplementedException();    
        }

        public Task<IEnumerable<CannotUnloadAppDomainException>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(_categoriaRepository.ObterTodos());
        }
    }
}
