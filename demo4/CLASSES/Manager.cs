using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.CLASSES
{
    public class Manager
    {
        public int ID { get; set; }
        public int JuniorMinimum { get; set; }
        public int MiddleMinimum { get; set; }
        public int SeniorMinimum { get; set; }
        public decimal AnalysisCoefficient { get; set; }
        public decimal InstallationCoefficient { get; set; }
        public decimal SupportCoefficient { get; set; }
        public decimal TimeCoefficient { get; set; }
        public decimal DifficultyCoefficient { get; set; }
        public decimal ToMoneyCoefficient { get; set; }
    }
}
