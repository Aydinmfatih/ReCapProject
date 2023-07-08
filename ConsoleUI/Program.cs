using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
var result = carManager.GetAll();
foreach (var item in result.Data)
{
   result.Data.SingleOrDefault(p=>p.Id == item.Id);
}



