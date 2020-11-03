using EntityFramwork1N.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork1N
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContext db = new LojaContext();

            Produto p = db.Produtos.Find(3);

            Console.WriteLine(p.Marca.Nome);

            //db.Produtos.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
