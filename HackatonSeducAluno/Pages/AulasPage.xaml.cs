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

			var aulas = new List<object>();

			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });
			aulas.Add(new object { });

			ListaDeAulas.ItemsSource = aulas;
		}
		}
	}

