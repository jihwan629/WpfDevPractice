using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBasicControlApp4
{
    public class CurrencyConverterViewModel : Notifier
    {
        private decimal euros;
        
        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        private decimal dolloars;

        public decimal Dollars
        {
            get { return dolloars; }
            set
            {
                dolloars = value;
                OnPropertyChanged("Dollars");
            }
        }

        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }
    }
}
