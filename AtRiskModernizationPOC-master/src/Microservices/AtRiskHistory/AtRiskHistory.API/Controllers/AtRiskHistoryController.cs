using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AtRiskHistory.Repository;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace AtRiskHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtRiskHistoryController : ControllerBase
    {
        private readonly IAtRiskHistoryRepo _AtRiskHistoryRepository;

        public AtRiskHistoryController(IAtRiskHistoryRepo AtRiskHsRepository)
        {
            _AtRiskHistoryRepository = AtRiskHsRepository;
            if (_AtRiskHistoryRepository.GetAtRiskEmployeeDetails().Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _AtRiskHistoryRepository.GetAtRiskEmployeeDetails();

            }
        }

        //GET: api/AtRiskHistory
        //[HttpGet]
        // public async Task<IActionResult> GetAtRiskHistory()
        // {
        //     var transactionResult = await _AtRiskHistoryRepository.GetAtRiskEmployeeDetailsAsync();
        //     return Ok(transactionResult);
        // }

        // GET: api/AtRiskHistory
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = _AtRiskHistoryRepository.GetAtRiskEmployeeDetails();
            return new OkObjectResult(products);

        }


        // GET: api/AtRiskHistory/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
