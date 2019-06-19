using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtRiskHistory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;

namespace AtRiskHistory.Repository
{
    public class AtRiskHistoryRepo : IAtRiskHistoryRepo
    {
        private readonly AtRiskHistoryContext _dbContext;

        public AtRiskHistoryRepo(AtRiskHistoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.AtRiskHistory> GetAtRiskEmployeeDetails()
        {

            return _dbContext.AtRiskHistory.ToList();
        }
        public async Task<IList<Models.AtRiskHistory>> GetAtRiskEmployeeDetailsAsync()
        {
            return await _dbContext.Set<Models.AtRiskHistory>().ToListAsync();
        }
    }

}
