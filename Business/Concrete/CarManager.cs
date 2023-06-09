﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Caching;
using Core.Aspects.Transaction;
using Core.Aspects.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; 

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarServiceGet")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
             return new SuccessResult(Messages.ProductAdded);

        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }

        public IResult Delete(Car car)
        {
             _carDal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Car> GetByCarId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id == id));  
        }
        
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarServiceGet")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
