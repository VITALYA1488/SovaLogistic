namespace SovaLogistic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateRegistration { get; set; }

        [StringLength(50)]
        public string PlaceDeparture { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateArrival { get; set; }

        [StringLength(50)]
        public string PlaceArrival { get; set; }

        public int UsersID { get; set; }

        public int TransportID { get; set; }

        public int ClientID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Transport Transport { get; set; }

        public virtual Users Users { get; set; }
    }
}
