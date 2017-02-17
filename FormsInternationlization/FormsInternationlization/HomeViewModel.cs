using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsInternationlization
{
	public class HomeViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged([CallerMemberName] string propertyName = "") =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		string _name = "Company".Translate();
		public string Name
		{
			get
			{
				return _name;
			}

			set
			{
				_name = value;
				RaisePropertyChanged("Name");
			}
		}

		string _address = "Address".Translate();
		public string Address
		{
			get
			{
				return _address;
			}

			set
			{
				_address = value;
				RaisePropertyChanged("Address");
			}
		}
	}
}
