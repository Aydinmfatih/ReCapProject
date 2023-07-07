using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());
//var result = carManager.GetAll();
//foreach (var item in result.Data)
//{
//    Console.WriteLine(item.Id);
//}




customerManager.Insert(new Customer
{
    Id = 1,
    CompanyName = null,
    UserId = 1
});