using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PgKits.Application.DTOs;

namespace PgKits.Application.Interfaces
{
    public interface IOrderService
    {
        Task<OrderResultDTO> GenerateOrderAsync(IEnumerable<KitRequestDTO> request);
    }
}
