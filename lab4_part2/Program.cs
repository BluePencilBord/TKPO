using System;

namespace FacadePattern
{
    public abstract class Property
    {
        public int InsuranceTerm { get; set; }
        public double Area { get; set; }
        public int ResidentsCount { get; set; }
        public int YearBuilt { get; set; }
        public double WearPercent { get; set; }

        protected Property(int insuranceTerm, double area, int residentsCount, int yearBuilt, double wearPercent)
        {
            InsuranceTerm = insuranceTerm;
            Area = area;
            ResidentsCount = residentsCount;
            YearBuilt = yearBuilt;
            WearPercent = wearPercent;
        }

        public abstract double GetPropertyTypeMultiplier();
    }

    public class Apartment : Property
    {
        public Apartment(int insuranceTerm, double area, int residentsCount, int yearBuilt, double wearPercent)
            : base(insuranceTerm, area, residentsCount, yearBuilt, wearPercent) { }

        public override double GetPropertyTypeMultiplier() => 1.0;
    }

    public class Townhouse : Property
    {
        public Townhouse(int insuranceTerm, double area, int residentsCount, int yearBuilt, double wearPercent)
            : base(insuranceTerm, area, residentsCount, yearBuilt, wearPercent) { }

        public override double GetPropertyTypeMultiplier() => 1.2;
    }

    public class Cottage : Property
    {
        public Cottage(int insuranceTerm, double area, int residentsCount, int yearBuilt, double wearPercent)
            : base(insuranceTerm, area, residentsCount, yearBuilt, wearPercent) { }

        public override double GetPropertyTypeMultiplier() => 1.5;
    }

    internal class BaseInsuranceCalculator
    {
        public double CalculateBasePremium(double area, int yearBuilt, double wearPercent)
        {
            double baseRate = 50;
            double ageFactor = Math.Max(1 - (DateTime.Now.Year - yearBuilt) * 0.01, 0.5);
            double wearFactor = 1 - wearPercent / 100;

            return area * baseRate * ageFactor * wearFactor;
        }
    }

    internal class ResidentsDiscount
    {
        public double CalculateDiscount(int residentsCount)
        {
            if (residentsCount <= 1) return 1.0;
            if (residentsCount <= 3) return 0.95;
            return 0.90;
        }
    }

    public class InsuranceFacade
    {
        private readonly BaseInsuranceCalculator _baseCalculator;
        private readonly ResidentsDiscount _residentsDiscount;

        public InsuranceFacade()
        {
            _baseCalculator = new BaseInsuranceCalculator();
            _residentsDiscount = new ResidentsDiscount();
        }

        public double CalculateInsurancePremium(Property property)
        {
            double basePremium = _baseCalculator.CalculateBasePremium(property.Area, property.YearBuilt, property.WearPercent);
            double typeMultiplier = property.GetPropertyTypeMultiplier();
            double discount = _residentsDiscount.CalculateDiscount(property.ResidentsCount);

            return basePremium * typeMultiplier * discount * property.InsuranceTerm;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var facade = new InsuranceFacade();

            var apartment = new Apartment(1, 60, 2, 2010, 10); // Квартира: 60 м², 2 проживающих, построена в 2010, износ 10%
            var townhouse = new Townhouse(2, 120, 4, 2000, 15); // Таунхаус: 120 м², 4 проживающих, построен в 2000, износ 15%
            var cottage = new Cottage(3, 200, 5, 1995, 20);     // Коттедж: 200 м², 5 проживающих, построен в 1995, износ 20%

            Console.WriteLine($"Страховой взнос за квартиру: {facade.CalculateInsurancePremium(apartment):F2} руб.");
            Console.WriteLine($"Страховой взнос за таунхаус: {facade.CalculateInsurancePremium(townhouse):F2} руб.");
            Console.WriteLine($"Страховой взнос за коттедж: {facade.CalculateInsurancePremium(cottage):F2} руб.");
        }
    }
}