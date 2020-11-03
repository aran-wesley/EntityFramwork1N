using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1N.Entidades
{
    [Table("Produtos")]
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
