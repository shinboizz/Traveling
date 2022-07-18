namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienHe")]
    public partial class LienHe
    {
        //public LienHe()
        //{
        //    LienHes = new HashSet<LienHe>();
        //}
        public int ID { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string customerName { get; set; }

        [StringLength(50)]
        public string customerEmail { get; set; }

        [StringLength(50)]
        public string contactSubject { get; set; }

        [StringLength(50)]
        public string contactMessage { get; set; }

        //public virtual ICollection<LienHe> LienHes { get; set; }
    }
}
