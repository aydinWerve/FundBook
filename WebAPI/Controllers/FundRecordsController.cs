using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundRecordsController : ControllerBase
    {
        IFundRecordService _fundRecordService;

        public FundRecordsController(IFundRecordService fundRecordService)
        {
            _fundRecordService = fundRecordService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fundRecordService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _fundRecordService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FundRecord fundRecord)
        {
            var result = _fundRecordService.Add(fundRecord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(FundRecord fundRecord)
        {
            var result = _fundRecordService.Delete(fundRecord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FundRecord fundRecord)
        {
            var result = _fundRecordService.Update(fundRecord);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
