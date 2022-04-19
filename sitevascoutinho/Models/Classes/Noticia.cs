using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sitevascoutinho.Models.Classes
{
	[Table("Noticia")]
	public class Noticia
	{
		[Column("Id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("Titulo")]
		[Display(Name = "Título")]
		public string? Titulo { get; set; }

		[Column("Corpo")]
		[Display(Name = "Corpo")]
		public string? Corpo { get; set; }
		[DataType(DataType.MultilineText)]
		[Column("Descricao")]
		[Display(Name = "Descrição")]
		public string? Descricao { get; set; }

	}
}
