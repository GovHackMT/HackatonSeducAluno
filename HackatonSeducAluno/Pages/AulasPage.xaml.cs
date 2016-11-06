using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HackatonSeducAluno
{
	public partial class AulasPage : ContentPage
	{
		public AulasPage ()
		{

			BindingContext = new AulasViewModel(Navigation);
			InitializeComponent();

			var aulas = new List<ListaDeAulas>();

			aulas.Add(new ListaDeAulas { NomeDaMateria = "Matemática", NomeDoProfessor = "João Marcos" });
			aulas.Add(new ListaDeAulas { NomeDaMateria = "Inglês", NomeDoProfessor = "Márcia Santos" });
			aulas.Add(new ListaDeAulas { NomeDaMateria = "Biologia", NomeDoProfessor = "Antônio Medeiros" });
			aulas.Add(new ListaDeAulas { NomeDaMateria = "Química", NomeDoProfessor = "Jairo Campos" });
			aulas.Add(new ListaDeAulas { NomeDaMateria = "Física", NomeDoProfessor = "Adevair Lemos" });

			ListaDeAulas.ItemsSource = aulas;
		}
	}
}

