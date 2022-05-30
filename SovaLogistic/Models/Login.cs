namespace SovaLogistic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginID { get; set; }

        [Column("Login")]
        [StringLength(50)]
        public string Login1 { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int UsersID { get; set; }

        public virtual Users Users { get; set; }
    }
}
