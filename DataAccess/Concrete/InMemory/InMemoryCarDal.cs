using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
            
            new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=35800, ModelYear="2020", Description="Auidi"},
            new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=40000, ModelYear="2020", Description="BMW"},
            new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=50000, ModelYear="2020", Description="Mercedes"},

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptade = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUptade.ColorId = car.ColorId;
            carToUptade.BrandId = car.BrandId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
            carToUptade.ModelYear = car.ModelYear;
        }
    }
}
