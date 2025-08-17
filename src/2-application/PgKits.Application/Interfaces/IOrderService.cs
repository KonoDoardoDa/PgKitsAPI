using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDTO> GenerateOrderAsync(List<OrderRequestDTO> orderRequest);
    }
}
