using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtRiskHistory.Controllers;
using AtRiskHistory.Models;
using AtRiskHistory.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Abstractions;


namespace AtRiskHistory.test
{
    [TestClass]
    public class AtRiskApiTestClass
    {
        [TestMethod]
        public void GetAtRiskHistory()
        {
           
            var connectionString = "User ID=postgres;Password=mahendra!sbl9409;Server=173.255.117.156;Port=5432;Database=postgres";
            var builder = new DbContextOptionsBuilder<AtRiskHistoryContext>()
                .EnableSensitiveDataLogging()
                .UseNpgsql(connectionString);

            AtRiskHistoryContext atRiskContext = new AtRiskHistoryContext(builder.Options);
            AtRiskHistoryRepo atRiskHistoryRepo = new AtRiskHistoryRepo(atRiskContext); 
            AtRiskHistoryController atRiskController = new AtRiskHistoryController(atRiskHistoryRepo);
            //AtRiskHistory.Models.AtRiskHistory atRisk = atRiskController.Get(); 
        }
    }
}
