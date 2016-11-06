using System;
using Xamarin.Forms;

namespace HackatonSeducAluno {
	public class DetalheDeAulasViewModel : BaseViewModel {
		public DetalheDeAulasViewModel(ListaDeAulas AulaSelecionada, INavigation Navigation) : base(Navigation) {
			
		}

		private ListaDeAulas _aulaSelecionada;
		private Command _returnPageCommand;
		private Command _advancePageCommand;

		public ListaDeAulas AulaSelecionada {
			get {
				return _aulaSelecionada;
			}
			set {
				_aulaSelecionada = value;
				OnPropertyChanged("AulaSelecioada");
			}
		}

		public Command AdvancePageCommand {
			get {
				return _advancePageCommand ?? (_advancePageCommand = new Command ((obj) => ExecuteAdvancePageCommand(obj)));
			}
		}

		public Command ReturnPageCommand {
			get {
				return _returnPageCommand ?? (_returnPageCommand = new Command((obj) => ExecuteReturnPageCommand(obj)));
			}

		}

		async void ExecuteReturnPageCommand(object obj) {
			//throw new NotImplementedException();
			await Navigation.PopAsync();
		}

		async void ExecuteAdvancePageCommand(object obj) {
			//throw new NotImplementedException();
			var result = await App.Current.MainPage.DisplayActionSheet("Confirmar Lançamento? ", null, null, "Sim", "Não");
			if (result == "Sim") {;
				await App.Current.MainPage.DisplayAlert("Sucesso", "Registrado com sucesso", "OK");
				await Navigation.PopToRootAsync();
			} else {
				return;
			}
		}
	}
}
