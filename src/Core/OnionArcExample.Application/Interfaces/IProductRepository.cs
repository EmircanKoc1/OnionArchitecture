using OnionArcExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
