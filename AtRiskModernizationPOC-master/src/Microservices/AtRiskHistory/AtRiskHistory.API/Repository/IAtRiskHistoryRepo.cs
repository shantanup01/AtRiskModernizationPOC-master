using System.Collections.Generic;
using System.Threading.Tasks;
using AtRiskHistory.Models;
using Google.Apis.DLP.v2;

namespace AtRiskHistory.Repository
{
    public interface IAtRiskHistoryRepo
    {
        IEnumerable<Models.AtRiskHistory> GetAtRiskEmployeeDetails();
        Task<IList<Models.AtRiskHistory>> GetAtRiskEmployeeDetailsAsync();
        
    }
}
