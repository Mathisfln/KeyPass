namespace KeyPass2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("keypass.password")]
    public partial class password
    {
        [Key]
        public int id_password { get; set; }

        public int id_user { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string description { get; set; }

        [Required]
        [StringLength(20)]
        public string type { get; set; }

        [Required]
        [StringLength(50)]
        public string password_user { get; set; }
    }
}
