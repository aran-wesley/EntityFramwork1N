using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1N.Entidades
{
    [Table("Marca")]
   public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
