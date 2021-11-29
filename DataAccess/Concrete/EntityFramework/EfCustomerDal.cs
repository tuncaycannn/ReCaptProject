using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RecapProjectContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var result = from cus in filter is null ? context.Customers : context.Customers.Where(filter)
                             join usr in context.Users on cus.Id equals usr.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = cus.UserId,
                                 UserId = usr.Id,
                                 FirstName = usr.FirstName,
                                 LastName = usr.LastName,
                                 CompanyName = cus.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
