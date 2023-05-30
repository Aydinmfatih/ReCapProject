using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var cars in carManager.GetAll())
{
    Console.WriteLine(cars.Description);
}
foreach (var carsId in carManager.GetById(1))
{
    Console.WriteLine(carsId.Description);
}

