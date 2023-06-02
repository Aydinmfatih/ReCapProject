using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

//carManager.Insert(new Car { Id = 4, BrandId = 2, ColorId = 3, Description = "good white", DailyPrice = 876, ModelYear = "2022" });
//carManager.Delete(new Car { Id = 4 });
carManager.GetAll();

