using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp1
{
    enum TicketType
    {
        Standard = 0,
        VIP = 1,
        IMAX = 2
    }
    struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
    internal class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }

        private double Price;

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string movieName)
        {
            MovieName = movieName;
            Type = TicketType.Standard;
            Seat = new Seat('A', 1);
            Price = 50;
        }
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }
        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }
        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie   : {MovieName}");
            Console.WriteLine($"Type    : {Type}");
            Console.WriteLine($"Seat    : {Seat}");
            Console.WriteLine($"Price   : {Price:F2}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):F2}");
        }
    }
}
