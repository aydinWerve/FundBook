using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class FundRecordManager : IFundRecordService
    {
        IFundRecordDal _fundRecordDal;

        public FundRecordManager(IFundRecordDal fundRecordDal)
        {
            _fundRecordDal = fundRecordDal;
        }

        public IDataResult<List<FundRecord>> GetAll()
        {
            return new SuccessDataResult<List<FundRecord>>(_fundRecordDal.GetAll(), Messages.Listed);
        }

        public IDataResult<FundRecord> GetById(int fundRecordId)
        {
            return new SuccessDataResult<FundRecord>(_fundRecordDal.Get(f => f.Id == fundRecordId));
        }

        public IDataResult<List<FundRecordDetailDto>> GetFundRecordDetailDTOs()
        {
            return new SuccessDataResult<List<FundRecordDetailDto>>(_fundRecordDal.GetFundRecordDetailDTOs());
        }

        public IResult Add(FundRecord fundRecord)
        {
            _fundRecordDal.Add(fundRecord);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(FundRecord fundRecord)
        {
            _fundRecordDal.Delete(fundRecord);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(FundRecord fundRecord)
        {
            _fundRecordDal.Update(fundRecord);
            return new SuccessResult(Messages.Updated);
        }
    }
}
