using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());
//var result = carManager.GetAll();
//foreach (var item in result.Data)
//{
//    Console.WriteLine(item.Id);
//}

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

customerManager.Insert(new Customer
{
    Id = 1,
    CompanyName = null,
    UserId = 1
});