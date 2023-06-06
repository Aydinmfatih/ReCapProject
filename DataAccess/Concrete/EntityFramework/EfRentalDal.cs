using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalCarDetailDto> GetRentalCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cr in context.Customers
                             on r.CustomerId equals cr.UserId
                             join u in context.Users
                             on cr.UserId equals u.Id
                             select new RentalCarDetailDto
                             {
                                 Id = r.Id,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
