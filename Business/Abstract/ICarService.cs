using Core.Utilities.Results.Abstract;
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
        IResult AddCar(Car car);
        IResult UpdateCar(Car car);
        IResult DeleteCar(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int colorId);


    }
}
