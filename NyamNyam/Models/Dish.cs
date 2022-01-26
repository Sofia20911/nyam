namespace NyamNyam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            Processes = new HashSet<Process>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DishName { get; set; }

        public int BaseServings { get; set; }

        public int Category { get; set; }

        [Required]
        [StringLength(50)]
        public string ImagePath { get; set; }

        [Required]
        public string SourceRecipe { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string FinalPrice { get; set; }

        public byte[] MainImage { get; set; }

        public virtual Category Category1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Process> Processes { get; set; }
    }
}
