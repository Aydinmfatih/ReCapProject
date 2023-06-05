using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>>  GetAll();
        IDataResult<Car> GetByCarId(int id);
        IResult Insert(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
       
    }

}
