using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IFundRecordService
    {
        IDataResult<List<FundRecord>> GetAll();
        IDataResult<FundRecord> GetById(int fundRecordId);
        IDataResult<List<FundRecordDetailDto>> GetFundRecordDetailDTOs();
        IResult Add(FundRecord fundRecord);
        IResult Delete(FundRecord fundRecord);
        IResult Update(FundRecord fundRecord);
    }
}
