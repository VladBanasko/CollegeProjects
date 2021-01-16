using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTFVladyslavBanasko
{
    public enum CardType { Visa, Mastercard };
    public class CreditCard
    {


        public CardType TypeOfCard { get; set; }
        public string CardholderName { get; set; }
        public long CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public int Ccv { get; set; }

        public CreditCard(CardType type, string name, long number, string date, int cvv)
        {
            TypeOfCard = type;
            CardholderName = name;
            CardNumber = number;
            ExpiryDate = date;
            Ccv = cvv;
        }

        public override string ToString()
        {
            return $"CardType is  { TypeOfCard}" +
                $"\nName is {CardholderName}" +
                $"\nCard Number is {CardNumber}" +
                $"\nExpiry date is {ExpiryDate}" +
                $"\nCVV is {Ccv}";
        }


    }
}
