using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _CategoriaCaminhoArquivo;

        public CategoriaRepository()
        {
            _CategoriaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Categoria.json");

        }

        public void Adicionar(Categoria categoria)
        {
            List<Categoria> categorias = new List<Categoria>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            categorias.Add(categoria);
            EscreverProdutosNoArquivo(categorias);
        }

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

       

     

        #region Métodos arquivo
        private List<Categoria> LerProdutosDoArquivo()
        {
            if (!System.IO.File.Exists(_CategoriaCaminhoArquivo))
            {
                return new List<Categoria>();
            }

            string json = System.IO.File.ReadAllText(_CategoriaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Categoria>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Categoria> categoria = LerProdutosDoArquivo();
            if (categoria.Any())
            {
                return categoria.Max(p => p.Codigo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverProdutosNoArquivo(List<Categoria> categoria)
        {
            string json = JsonConvert.SerializeObject(categoria);
            System.IO.File.WriteAllText(_CategoriaCaminhoArquivo, json);
        }

        Task<Categoria> ICategoriaRepository.ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return LerProdutosDoArquivo();
        }




        #endregion
    }
}
