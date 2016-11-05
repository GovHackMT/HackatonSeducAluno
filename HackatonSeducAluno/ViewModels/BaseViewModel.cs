using System;
using System.ComponentModel;

using Xamarin.Forms;
namespace HackatonSeducAluno {
	public class BaseViewModel : INotifyPropertyChanged {
		public INavigation Navigation {
			get;
			set;
		}

		public BaseViewModel(INavigation navigation) {
			Navigation = navigation;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string PropertyName) {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
			}
		}
	}
}
