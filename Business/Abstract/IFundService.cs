using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFundService
    {
        IDataResult<List<Fund>> GetAll();
        IDataResult<Fund> GetById(int fundId);
        IResult Add(Fund fund);
        IResult Delete(Fund fund);
        IResult Update(Fund fund);
    }
}
