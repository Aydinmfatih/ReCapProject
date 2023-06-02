using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Insert(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Database kaydedildi");
            }
            else
            {
                throw new Exception("Araba günlük fiyatı 0 dan büyük olmalıdır veya açıklaması 2 karakterden fazla olmalıdır");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return  _carDal.GetAll();
        }

        public Car GetByCarId(int id)
        {
            return _carDal.Get(p=>p.Id == id);  
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
