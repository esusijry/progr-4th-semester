namespace ApartmentLibrary.UnitTests
{
    [TestFixture]
    public class ApartmentUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var ap = CreateTestApartment();

            Assert.That(ap.Number, Is.EqualTo(10));
            Assert.That(ap.OwnerName, Is.EqualTo("Иван Иванов"));
            Assert.That(ap.PhoneNumber, Is.EqualTo("123456"));
            Assert.That(ap.ElectricityType, Is.EqualTo(ElectricityMeterType.DualTariff));
        }

        [Test]
        public void GetInfoTest()
        {
            var ap = CreateTestApartment();
            var info = ap.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Квартира 10, Иван Иванов"));
            Assert.That(info[1],
                Is.EqualTo("Телефон: 123456, ХВС: 100, ГВС: 50, День: 200, Ночь: 150"));
        }

        private Apartment CreateTestApartment()
        {
            return new Apartment(
                10,
                "Иван Иванов",
                "123456",
                100,
                50,
                ElectricityMeterType.DualTariff,
                new double[] { 200, 150 });
        }
    }
}