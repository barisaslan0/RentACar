using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalService _rentalService;
        public RentalManager(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                _rentalService.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

            return new ErrorResult(Messages.CarMustReturn);
        }

        public IResult Delete(Rental rental)
        {
            _rentalService.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalService.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
