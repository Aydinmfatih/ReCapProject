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
    public class EfUserDal : EfRepositoryBase<User, RentACarContext>, IUserDal
    {
        public List<User> GetUserDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from user in context.Users
                             join customer in context.Customers on user.Id equals customer.UserId
                             select new UserDetailDto
                             {
                                 Id= user.Id,
                                 FirstName= user.FirstName,
                                 LastName= user.LastName,
                                 Email= user.Email,
                                 Password= user.Password,
                             };

                return result.ToList();
            }
        }
    }
}
