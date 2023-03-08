using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITechTest.DataModel
{
    public class CompanyDataModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VarChar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "VarChar(100)")]
        public string Address1 { get; set; }

        [Column(TypeName = "VarChar(100)")]
        public string Address2 { get; set; }

        [Column(TypeName = "VarChar(100)")]
        public string Address3 { get; set; }

        [Column(TypeName = "VarChar(20)")]
        public string Postcode { get; set; }

        [Column(TypeName = "VarChar(50)")]
        public string Country { get; set; }
        
        public bool Active { get; set; }
        
        public DateTime InsuranceEndDate { get; set; }
    }
}
