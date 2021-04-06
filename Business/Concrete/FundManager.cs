using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FundManager : IFundService
    {
        IFundDal _fundDal;

        public FundManager(IFundDal fundDal)
        {
            _fundDal = fundDal;
        }

        public IDataResult<List<Fund>> GetAll()
        {
            return new SuccessDataResult<List<Fund>>(_fundDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Fund> GetById(int fundId)
        {
            return new SuccessDataResult<Fund>(_fundDal.Get(f => f.Id == fundId));
        }
        public IResult Add(Fund fund)
        {
            _fundDal.Add(fund);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Fund fund)
        {
            _fundDal.Delete(fund);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Fund fund)
        {
            _fundDal.Update(fund);
            return new SuccessResult(Messages.Updated);
        }
    }
}
