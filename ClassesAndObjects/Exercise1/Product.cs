using System;

namespace Exercise1
{
    public class Product
    {
        
        private decimal _price;
        private int _amount;
        private string _name;

        public Product (string name, decimal priceAtStart, int amountAtStart)
        {
            this._name = name;
            this._price = priceAtStart;
            this._amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price: {_price}, amount: {_amount}");
        }

        public void AddAmount(int addedAmount)
        {
            _amount = _amount + addedAmount;
        }

        public void ChangePrice(decimal newPrice)
        {
            _price = newPrice;
        }
    }
}