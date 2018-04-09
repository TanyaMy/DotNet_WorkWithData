using System;
using System.IO;


namespace Car
{
   public class SportCar : CarBase
    {
        private string _carNameFilePath;
		
		public SportCar()
        {
            _carNameFilePath = "sport.txt";
        }

        public SportCar(string carNameFilePath)
        {
            _carNameFilePath = carNameFilePath;
        }

        public override void CarInfo()
        {
            base.CarInfo();
            Console.WriteLine(GetCarNameFromFile());
        }

        private string GetCarNameFromFile()
        {
            if (!File.Exists(_carNameFilePath))
            {
                return String.Empty;
            }

           return File.ReadAllText(_carNameFilePath);
        }
    }
}