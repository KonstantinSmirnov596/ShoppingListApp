using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    internal class ToDoMod: INotifyPropertyChanged
    {
        private bool _isBought;
        private double _price;
        private string _textGoods;
        private string _textShop;
        private string _textLink;
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsBought
        {
            get { return _isBought; }
            set
            {
                if (_isBought == value)
                    return;
                _isBought = value;
                OnPropertyChanged("IsBought");
            }   
        }
        public double Price
        {
            get { return _price; }
            set {
                if (_price == value)
                    return;
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        public string TextGoods
        {
            get { return _textGoods; }
            set {
                if (_textGoods == value)
                    return;
                _textGoods = value;
                OnPropertyChanged("TextGoods");
            }
        }
        public string TextShop
        {
            get { return _textShop; }
            set {
                if (_textShop == value)
                    return;
                _textShop = value;
                OnPropertyChanged("TextShop");
            }
        }
        public string TextLink
        {
            get { return _textLink; }
            set {
                if (_textLink == value)
                    return;
                _textLink = value;
                OnPropertyChanged("TextLink");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
