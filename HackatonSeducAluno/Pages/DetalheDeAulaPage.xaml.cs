using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HackatonSeducAluno {
	public partial class DetalheDeAulaPage : ContentPage {
		public DetalheDeAulaPage() {
			BindingContext = new DetalheDeAulasViewModel(Navigation);
			InitializeComponent();
			}
		}
	}
