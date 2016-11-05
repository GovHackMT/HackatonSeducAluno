using System;

using Xamarin.Forms;
namespace HackatonSeducAluno {
	public class LoginPageViewModel : BaseViewModel {
		public LoginPageViewModel(INavigation Navigation) : base(Navigation) {
			
		}

		private Aluno _aluno;
		private string _loginDeUsuario;
		private Command _realizaLogin;
		private Command _limpaDados;

		public Aluno Aluno {
			get {
				return _aluno;
			}
			set {
				_aluno = value;
				OnPropertyChanged("Aluno");
			}
		}

		public string LoginDeUsuario {
			get {
				return _loginDeUsuario;
			}

			set{
				_loginDeUsuario = value;
				OnPropertyChanged("LogindeUsuario");
			}
		}

		public Command LimpaEntradaDeDados {
			get {
				return _limpaDados ?? (_limpaDados = new Command((obj) => ExecuteLimpaDados(obj)));
			}
		}

		public Command RealizaLogin {
			get {
				return _realizaLogin ?? (_realizaLogin = new Command((obj) => ExecuteRealizaLogin(obj)));
			}
		}

		void ExecuteRealizaLogin(object obj) {
			throw new NotImplementedException();
			}

		void ExecuteLimpaDados(object obj) {
			throw new NotImplementedException();
			}
	}
}
