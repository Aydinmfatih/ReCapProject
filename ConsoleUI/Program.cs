using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var cars in carManager.GetCarsByColorId(3))
{
    Console.WriteLine(cars.ModelYear);
}


