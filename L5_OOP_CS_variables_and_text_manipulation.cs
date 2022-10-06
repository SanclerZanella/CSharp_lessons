using System;
					
public class Program
{
	public static void Main()
	{
		string fruit1, fruit2, fruit3; // Declare multiple variables of the same type on one line.
		int qty1, qty2, qty3;
		decimal price1, price2, price3;
		string unit1, unit2, unit3;
		
		fruit1 = "Apple";
		fruit2 = "Pear";
		fruit3 = "Banana";
		
		qty1 = 2;
		qty2 = 1;
		qty3 = 3;
		
		price1 = 0.50M;
		price2 = 0.70M;
		price3 = 0.40M;
		
		unit1 = "un";
		unit2 = "un";
		unit3 = "un";
		
		decimal subtotal1, subtotal2, subtotal3;
		
		subtotal1 = qty1 * price1;
		subtotal2 = qty2 * price2;
		subtotal3 = qty3 * price3;
		
		decimal discount = 0.10M;
		decimal subtotal= Decimal.Round((subtotal1 + subtotal2 + subtotal3), 2);
		discount = Decimal.Round((discount * subtotal), 2);
		decimal total = subtotal - discount;
		
		Console.WriteLine($"\t\t  __Receipt__ \n\n----------------------------------\n\n\t{qty1} x {fruit1} @ ${price1} {unit1} = ${subtotal1}\n\t{qty2} x {fruit2} @ ${price2} {unit2} = ${subtotal2}\n\t{qty3} x {fruit3} @ ${price3} {unit3} = ${subtotal3}\n\n----------------------------------\n\t\tSubtotal = ${subtotal}\n\t\tDiscount = ${discount}\n\t\tTotal = ${total}");
	}
}