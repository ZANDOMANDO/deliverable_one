using System;
namespace UsedCarLotLab
{
	public class Car
	{


        //Constructor
        public Car(string make, string model, int year, decimal price)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = price;

        }
        public Car()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public decimal Price { get; set; }






    }
}

