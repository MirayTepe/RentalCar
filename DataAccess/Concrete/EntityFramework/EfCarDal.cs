using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCars()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in context.tblCars
                             join b in context.tblBrands
                             on ca.BrandId equals b.BrandId
                             join co in context.tblColors
                             on ca.ColorId equals co.ColorId

                             select new CarDetailDto
                             {
                              CarId= ca.CarId,
                              CarName =ca.CarName,
                              BrandName=b.BrandName,
                              ColorName =co.ColorName,
                              DailyPrice=ca.DailyPrice
                              };
                return result.ToList();
            }
        }
    }
}
