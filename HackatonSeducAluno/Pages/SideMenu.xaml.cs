using System;
using System.Collections.Generic;


using Xamarin.Forms;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;

namespace HackatonSeducAluno
{
	public partial class SideMenu : MasterDetailPage {
		public SideMenu (){
			
			InitializeComponent ();
			Detail = new NavigationPage(new  AulasPage());
		}

		void AbreAulasDoDia(object sender, System.EventArgs e) {
			Detail = new NavigationPage(new AulasPage());
			IsPresented = false;
		}

		async void Logout(object sender, System.EventArgs e) {

			var result = await DisplayActionSheet("Deseja sair?", null, null, "Sim", "Não");
			if (result == "Sim") {
				Application.Current.MainPage = new LoginPage();
				IsPresented = false;
				} else {
				return;
				}

			}
	}
}

