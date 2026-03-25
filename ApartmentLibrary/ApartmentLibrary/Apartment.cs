using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentLibrary
{
    public class Apartment
    {
        public int Number { get; }

        public string OwnerName { get; set; }
        public string PhoneNumber { get; set; }

        public double ColdWater { get; set; }
        public double HotWater { get; set; }

        public ElectricityMeterType ElectricityType { get; set; }
        public double[] ElectricityReadings { get; set; }

        public Apartment(int number, string ownerName, string phoneNumber,
                         double coldWater, double hotWater,
                         ElectricityMeterType type, double[] readings)
        {
            Number = number;
            OwnerName = ownerName;
            PhoneNumber = phoneNumber;

            ColdWater = coldWater;
            HotWater = hotWater;

            ElectricityType = type;
            ElectricityReadings = readings;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];

            info[0] = $"Квартира №{Number}, {OwnerName}";

            if (ElectricityType == ElectricityMeterType.SingleTariff)
                info[1] = $"Телефон: {PhoneNumber}, ХВС: {ColdWater}, ГВС: {HotWater}, Эл-во: {ElectricityReadings[0]}";
            else
                info[1] = $"Телефон: {PhoneNumber}, ХВС: {ColdWater}, ГВС: {HotWater}, День: {ElectricityReadings[0]}, Ночь: {ElectricityReadings[1]}";

            return info;
        }
    }
}