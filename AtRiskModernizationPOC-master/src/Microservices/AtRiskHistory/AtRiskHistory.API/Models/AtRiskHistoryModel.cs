using System;

namespace AtRiskHistory.Models
{
    public class AtRiskHistory
    {
        public int ID { get; set; }
        public int GIN { get; set; }
        public DateTime BEGINDATE { get; set; }
        public string CHANGETYPE { get; set; }
        public DateTime LASTCHANGE { get; set; }
        public int LASTCHANGEBY { get; set; }
        public string LASTCHANGEROLE { get; set; }
        public string BEFORE { get; set; }
        public string AFTER { get; set; }

    }
}

