namespace NyamNyam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IngredientRecipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IngredientRecipe()
        {
            Processes = new HashSet<Process>();
        }

        public int ID { get; set; }

        public int IngredientName { get; set; }

        public decimal Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Process> Processes { get; set; }
    }
}
