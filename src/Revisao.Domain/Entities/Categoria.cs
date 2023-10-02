using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Categoria
    {

        #region Construtores
       
        public Categoria(int codigo, string descriacao)
        {
            Codigo = codigo;
            Descriacao = descriacao;

        }
        #endregion
        #region Atributos
        public int Codigo { get; set; }
        public string Descriacao { get; set; }
        #endregion

        #region Funções

        #endregion

    }
}
