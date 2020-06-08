namespace KeyPass2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("keypass.user")]
    public partial class user
    {
        [Key]
        public int id_user { get; set; }

        [Required]
        [StringLength(40)]
        public string mail { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }
    }
}
