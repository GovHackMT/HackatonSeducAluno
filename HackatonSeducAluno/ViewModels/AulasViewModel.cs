using System;

using Xamarin.Forms;
namespace HackatonSeducAluno {
	public class AulasViewModel : BaseViewModel {


		public AulasViewModel(INavigation Navigation) : base(Navigation) {

		}

		private Aula _aula;
		private Aluno _aluno;
		private AulaAtividade _aulaAtividade;

		private Command _advancePageCommand;
		private Command _returnPageCommand;

		public Aula Aula {
			get {
				return _aula;
			}
			set {
				_aula = value;
				OnPropertyChanged("Aula");
			}
		}

		public Aluno Aluno {
			get {
				return _aluno;
			}
			set {
				_aluno = value;
				OnPropertyChanged("Aluno");
			}
		}

		public AulaAtividade AulaAtividade {
			get {
				return _aulaAtividade;
			}
			set {
				_aulaAtividade = value;
				OnPropertyChanged("AulaAtividade");
			}
		}

		public Command AdvancePageCommand {
			get {
				if (_advancePageCommand != null) {
					return (_advancePageCommand = new Command((obj) => ExecuteAdvancePage(obj)));
				} else {
					return _advancePageCommand;
				}
			
			}
		}

		public Command ReturnPageCommand {
			get {
				if (_advancePageCommand != null) {
					return (_returnPageCommand = new Command((obj) => ExecuteReturnPage(obj)));
				} else {
					return _advancePageCommand;
				}

			}
		}

		void ExecuteReturnPage(object obj) {
			throw new NotImplementedException();
			}

		async void ExecuteAdvancePage(object obj) {
			//Executar avançar página
			//throw new NotImplementedException();
			//await Navigation.PushAsync(new ConfirmaManutencaoPage(Equipamento, obj as Produto, Compartimento));
			await Navigation.PushAsync(new DetalheDeAulaPage());

		}
	}
}