using System.ComponentModel.DataAnnotations;

namespace OA1.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
