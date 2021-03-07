using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DbCarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DbCarRentalContext context = new DbCarRentalContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             join z in context.Colors
                             on p.ColorId equals z.Id
                                            

                             select new CarDetailDto 
                             { 
                                 Id = p.Id, 
                                 CarName = p.CarName, 
                                 BrandName = c.Name, 
                                 DailyPrice = p.DailyPrice,
                                 ColorName = z.Name,
                                 Description = p.Description
                             };
                return result.ToList();

            }
        }
    }
}
