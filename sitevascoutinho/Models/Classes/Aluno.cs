using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sitevascoutinho.Models.Classes
{
	[Table("Aluno")]
	public class Aluno
	{

		[Column("Id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("Nome")]
		[Display(Name = "Nome")]
		public string? Nome { get; set; }

		[Column("Data de nascimento")]
		[Display(Name = "Data de nascimento")]
		public string? DataNasc { get; set; }

		[Column("Descricao")]
		[Display(Name = "Descrição")]
		public string? Descricao { get; set; }
	}
}
