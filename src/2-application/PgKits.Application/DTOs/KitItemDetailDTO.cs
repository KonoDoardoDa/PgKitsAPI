using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.DTOs
{
    public record KitItemDetailDTO(int ItemId, string ItemName, string? SupplierName, int QuantityPerKit, int TotalForRequestedQuantity);
}
