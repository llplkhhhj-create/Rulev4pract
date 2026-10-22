namespace ModelEF
{
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Role_Name { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
