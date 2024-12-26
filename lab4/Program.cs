using System;

namespace AdapterPattern
{
    public interface ITarget
    {
        double CalculateDp(int T0, int dT);
        void ModifMass(double dm);
        string GetData();
    }

    public class GasCylinder
    {
        public double Volume { get; set; }
        public double Mass { get; set; }
        public double Molar { get; set; }

        private const double R = 8.31;

        public GasCylinder(double volume, double mass, double molar)
        {
            Volume = volume;
            Mass = mass;
            Molar = molar;
        }

        public double GetPressure(int T)
        {
            return (Mass / Molar) * R * T / Volume;
        }

        public double AmountOfMatter()
        {
            return Mass / Molar;
        }

        public override string ToString()
        {
            return $"Баллон: Объем={Volume} м³, Масса={Mass} кг, Молярная масса={Molar} кг/моль";
        }
    }

    public class GasCylinderAdapter : ITarget
    {
        private readonly GasCylinder _gasCylinder;

        public GasCylinderAdapter(GasCylinder gasCylinder)
        {
            _gasCylinder = gasCylinder;
        }

        public double CalculateDp(int T0, int dT)
        {
            double P0 = _gasCylinder.GetPressure(T0);
            double P1 = _gasCylinder.GetPressure(T0 + dT);
            return P1 - P0;
        }

        public void ModifMass(double dm)
        {
            _gasCylinder.Mass += dm;
        }

        public string GetData()
        {
            return _gasCylinder.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var gasCylinder = new GasCylinder(1.0, 2.0, 0.032);
            var adapter = new GasCylinderAdapter(gasCylinder);

            Console.WriteLine(adapter.GetData());
            Console.WriteLine($"Изменение давления: {adapter.CalculateDp(300, 50):F2} Па");
            adapter.ModifMass(1.0);
            Console.WriteLine(adapter.GetData());
        }
    }
}
