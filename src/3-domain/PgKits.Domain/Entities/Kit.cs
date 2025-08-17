using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Domain.Entities
{
    public class Kit
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public ICollection<KitItem> KitItens { get; set; } = new List<KitItem>();
    }
}
