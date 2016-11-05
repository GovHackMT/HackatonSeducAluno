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


	}
}

