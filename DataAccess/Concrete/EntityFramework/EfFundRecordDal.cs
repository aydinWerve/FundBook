using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFundRecordDal : EfEntityRepositoryBase<FundRecord, FundBookContext>, IFundRecordDal
    {
        public List<FundRecordDetailDto> GetFundRecordDetailDTOs()
        {
            using (FundBookContext context = new FundBookContext())
            {
                var result = from fr in context.FundRecords
                             join f in context.Funds on fr.FundId equals f.Id
                             select new FundRecordDetailDto { FundName = f.FundName, Description = fr.Description, Price = fr.Price, Date = fr.Date };
                return result.ToList();
            }
        }
    }
}
