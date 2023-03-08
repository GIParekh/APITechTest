using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace APITechTest.ViewModels
{
    public class ClaimViewModel
    {
        public string UCR { get; set; }
        
        public int CompanyId { get; set; }       
        
        public DateTime ClaimDate { get; set; }
        
        public DateTime LossDate { get; set; }
        
        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }

        public int ClaimDays { get; set; }

    }
}
