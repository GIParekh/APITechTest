using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace APITechTest.DataModel
{
    public class ClaimDataModel
    {
        [Key]
        [Column(TypeName = "VarChar(20)")]
        public string UCR { get; set; }
        
        public int CompanyId { get; set; }       
        
        public DateTime ClaimDate { get; set; }
        
        public DateTime LossDate { get; set; }
        
        [Column("Assured Name", TypeName = "Varchar(100)")]
        public string AssuredName { get; set; }


        [Column("Incurred Loss", TypeName = "Decimal(15, 2)")]
        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }

    }
}
