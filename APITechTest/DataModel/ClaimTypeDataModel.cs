using System.ComponentModel.DataAnnotations;

namespace APITechTest.DataModel
{
    public class ClaimTypeDataModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
