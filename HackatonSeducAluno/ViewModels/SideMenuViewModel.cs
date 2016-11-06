using System;

using Xamarin.Forms;
namespace HackatonSeducAluno {
	public class SideMenuViewModel : BaseViewModel {
		public SideMenuViewModel(String nomeDoAluno, INavigation Navigation) : base(Navigation) {
			NomeDeUsuario = nomeDoAluno;
		}

		private string _nomeDeUsuario;

		public string NomeDeUsuario {
			get {
				return _nomeDeUsuario;
			}
			set {
				_nomeDeUsuario = value;
				OnPropertyChanged("NomeDeUsuario");
			}
		}
	}
}
