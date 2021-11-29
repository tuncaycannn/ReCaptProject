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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapProjectContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var result = from rnt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cr in context.Cars on rnt.CarId equals cr.Id
                             join brd in context.Brands on cr.BrandId equals brd.Id
                             join col in context.Colors on brd.Id equals col.Id
                             join cus in context.Customers on rnt.CustomerId equals cus.UserId
                             join usr in context.Users on cus.UserId equals usr.Id
                             select new CarRentalDetailDto
                             {
                                 RentalId = rnt.Id,
                                 CustomerName = usr.FirstName,
                                 CustomerLastName = usr.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 BrandName = brd.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 RentDate = rnt.RentDate,
                                 ReturnDate = rnt.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
