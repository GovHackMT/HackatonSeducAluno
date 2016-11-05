using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonSeducAluno {
	public class BindableListView : ListView {
		public static BindableProperty ItemClickedCommandProperty = BindableProperty.Create(
			nameof(ItemClickedCommand),
			typeof(ICommand),
			typeof(BindableListView),
			default(ICommand)

		);
		public ICommand ItemClickedCommand {
			get { return (ICommand)this.GetValue(ItemClickedCommandProperty); }
			set { this.SetValue(ItemClickedCommandProperty, value); }
		}

		public BindableListView() {
			this.ItemTapped += OnItemTapped;
		}

		void OnItemTapped(object sender, ItemTappedEventArgs e) {
			if (ItemClickedCommand != null && ItemClickedCommand.CanExecute(e.Item)) {
				ItemClickedCommand.Execute(e.Item);
				//linha nova
				((ListView)sender).SelectedItem = null;
			}
		}
	}
}
