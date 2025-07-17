using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTS_BrainBox.Client.Entities.Admin
{
    [Table("AdministrationalDetails")]
    public class AdministrationalDetails
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string Role {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
