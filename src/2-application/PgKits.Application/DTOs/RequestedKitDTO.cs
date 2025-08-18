using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.DTOs
{
    public record RequestedKitDTO(int KitId, string KitName, int Quantity);
}
