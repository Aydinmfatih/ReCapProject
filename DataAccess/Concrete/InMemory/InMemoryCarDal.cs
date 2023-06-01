using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
           
            new Car{ Id = 1,BrandId=1,ColorId=1,ModelYear="1999",DailyPrice=34000,Description="Its a good car"},
            new Car{ Id = 2,BrandId=1,ColorId=3,ModelYear="1879",DailyPrice=37000,Description="Its a good car"}
            };
        }
      
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete=_cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id == id).ToList();
        }

       

        public void Update(Car car)
        {
            var productToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            productToUpdate.DailyPrice=car.DailyPrice;
            productToUpdate.Description=car.Description;
            productToUpdate.ModelYear=car.ModelYear;
            productToUpdate.ColorId = car.ColorId;
            

        }
    }
}
