using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HackatonSeducAluno {
	public partial class DetalheDeAulaPage : ContentPage {
		public DetalheDeAulaPage(ListaDeAulas AulaSelecionada) {
			BindingContext = new DetalheDeAulasViewModel(AulaSelecionada, Navigation);
			InitializeComponent();

			NomeDaMateria.Text = ("Matéria: " + AulaSelecionada.NomeDaMateria);
			NomeDoProfessor.Text = ("Professor: " + AulaSelecionada.NomeDoProfessor);

			PickerDeNota.Items.Add("1 estrela");
			PickerDeNota.Items.Add("2 estrelas");
			PickerDeNota.Items.Add("3 estrelas");
			PickerDeNota.Items.Add("4 estrelas");
			PickerDeNota.Items.Add("5 estrelas");

			EntryDeAtividades.Text = "Resolução de exercícios do capítulo 5 \n Entrega do relatório de atividades mensal dia 12/12";
		}
	}
}