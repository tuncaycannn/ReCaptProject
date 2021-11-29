using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int id);
        IDataResult<List<Car>> GetCarByColorId(int id);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int id);

    }
}
