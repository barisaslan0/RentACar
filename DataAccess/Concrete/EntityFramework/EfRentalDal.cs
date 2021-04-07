using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from rental in context.Rentals

                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId

                             join user in context.Users
                             on customer.UserId equals user.UserId

                             select new RentalDetailDto
                             {
                                 CarName = $"{brand.BrandName} {car.ModelName}",
                                 CustomerName = $"{user.FirstName} {user.LastName}",
                                 Date = $"{ rental.RentDate } - { rental.ReturnDate }"
                             };
                return result.ToList();
            }
        }
    }
}
