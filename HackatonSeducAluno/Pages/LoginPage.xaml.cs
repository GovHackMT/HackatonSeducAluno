using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HackatonSeducAluno
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			BindingContext = new LoginPageViewModel(Navigation);
			InitializeComponent ();

		}

		void CleanCamps(Object sender, EventArgs e) {

			EntradaDeLogin.Text = null;
			EntradaDeSenha.Text = null;

		}

		void OnLoginClick(object sender, System.EventArgs e) {
			Application.Current.MainPage = new SideMenu();
		}

	}
}

