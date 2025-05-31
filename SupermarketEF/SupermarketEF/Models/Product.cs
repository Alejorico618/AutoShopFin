using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketEF.Models
{
    public class Product
    {
        public int Id { get; set; }              // llave primaria
        public string Name { get; set; }

        // Se cierra correctamente el paréntesis y corchete
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        // FK correcta: eliminamos el typo “CatergoryId”
        public int CategoryId { get; set; }      // llave foránea

        // Navegación a la entidad Category (el nombre y tipo deben coincidir)
        public Category Category { get; set; }
    }
}
