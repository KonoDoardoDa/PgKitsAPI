using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Domain.Entities
{
    public class KitItem
    {
        public int KitId { get; set; }
        public Kit Kit { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public int Quantidade { get; set; }
    }
}
