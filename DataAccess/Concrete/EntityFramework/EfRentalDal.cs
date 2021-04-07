using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DbCarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (DbCarRentalContext context = new DbCarRentalContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = car.Id,
                                 CarName = car.CarName,
                                 CustomerName = customer.CompanyName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 ColorName = color.Name,
                                 BrandName = brand.Name
                             };

                return result.ToList();
            }
        }
    }
}
