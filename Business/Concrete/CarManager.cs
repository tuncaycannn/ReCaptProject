﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll());
        }

        [SecuredOperation("admin")]
        public IResult Add(Car car)
        {
            if (car.CarName.Length <= 2 && car.DailyPrice < 0)
            {
                return new ErrorResult(Messages.CarNameAndPriceValid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }


        public IDataResult<List<Car>> GetCarByBrandId(int id)
        {

            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>
                (_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            return new SuccessDataResult<List<CarDetailDto>>
                (_carDal.GetCarDetails());
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>
                (_carDal.Get(c => c.Id == id));
        }
    }
}
