namespace NyamNyam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            IngredientRecipes = new HashSet<IngredientRecipe>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string IngredientName { get; set; }

        [Required]
        [StringLength(50)]
        public string PricePerUnit { get; set; }

        [Required]
        [StringLength(50)]
        public string MainUnit { get; set; }

        public int count_in_stock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
