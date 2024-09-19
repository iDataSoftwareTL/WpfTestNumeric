using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestNumeric.ViewModel
{
	public class DaneViewModel : ObservableValidator
	{
		
		private double kwota;

		private string text;
        public double Kwota
		{
			get { return kwota; }
			set
			{
				kwota = value;
				OnPropertyChanged("Kwota");
			}
		}

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }

    }
}
