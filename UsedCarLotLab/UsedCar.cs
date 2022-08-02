using System;
namespace UsedCarLotLab
{
	public class UsedCar: Car
	{
        //Constructor
        public UsedCar(string make, string model, int year, decimal price,double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public double Mileage { get; set; }


    }
}

