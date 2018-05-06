﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TOYOTA.API.Models;
using TOYOTA.API.Models.CasesInfo;
using TOYOTA.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOYOTA.API.Controllers
{
    //[Authorize]
    [Route("toyota/api/v1/[controller]/[action]")]
    public class CasesInfoController : Controller
    {
        ICasesInfoService _casesInfoService;
        public CasesInfoController(ICasesInfoService casesInfoService)
        {
            _casesInfoService = casesInfoService;
        }
        [HttpPost]
        [ActionName("SaveCaseInfo")]
        public async Task<APIResult> SaveCaseInfo([FromBody]CasesParamDto paramDto)
        {
            return await _casesInfoService.InsertOrUpdateCasesInfo(paramDto);
        }
        [HttpGet]
        [ActionName("GetCaseInfo")]
        public async Task<IActionResult> GetCaseInfo()
        {
            if (Request.Query.Count>1)
            {
                var resultDto = await _casesInfoService.SearchCasesList(Request.Query["sDate"],
                Request.Query["eDate"], Request.Query["caseType"], Request.Query["content"], Request.Query["inUserId"]);
                return Ok(resultDto);
            }
            else
            {
                var resultDto = await _casesInfoService.SearchCasesDetail(Request.Query["caseId"]);
                return Ok(resultDto);

            }
        }
        // PUT api/values/5
        [HttpPost]
        [ActionName("UpdateCaseInfo")]
        public async Task<APIResult> UpdateCaseInfo([FromBody]CasesDelParamDto paramDto)
        {
            return await _casesInfoService.DeleteCasesInfo(paramDto);
        }
    }
}
