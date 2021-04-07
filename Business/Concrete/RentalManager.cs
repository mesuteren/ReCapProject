using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        [ValidationAspect(typeof(RentalValidator))]

        //kendime not
        //burada araba verilmişse ve dönmemişse tekrar kiralanamaz kuralı yaz
        //araba verilince değer false geri gelince true gibi bir property ekle
        //bu şekilde ilerle

        public IResult Add(Rental rental)
        {
            List<Rental> rentalsToCheck = _rentalDal.GetAll(r => r.Id == rental.Id);
            foreach (Rental rentalObject in rentalsToCheck)
            {
                if (rentalObject.ReturnDate == null)
                {
                    return new ErrorResult("Araç uygun değil");
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }




        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }


    }
}
