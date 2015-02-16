using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDesignPatterns
{
    internal class AbstractFactory
    {
        public abstract class CarFactory
        {
            public abstract SportsCar CreateSportsCar();
            public abstract FamilyCar CreateFamilyCar();
        }

        public class AudiFactory : CarFactory
        {
            public override SportsCar CreateSportsCar()
            {
                return new AudiSportsCar();
            }

            public override FamilyCar CreateFamilyCar()
            {
                return new AudiFamilyCar();
            }
        }

        public class MercedesFactory : CarFactory
        {
            public override SportsCar CreateSportsCar()
            {
                return new MercedesSportsCar();
            }

            public override FamilyCar CreateFamilyCar()
            {
                return new MercedesFamilyCar();
            }
        }

        public abstract class SportsCar
        {
        }

        public abstract class FamilyCar
        {
            public abstract void Speed(SportsCar abstractFamilyCar);
        }

        private class MercedesSportsCar : SportsCar
        {
        }

        private class MercedesFamilyCar : FamilyCar
        {
            public override void Speed(SportsCar abstractSportsCar)
            {
                Console.WriteLine(GetType().Name + " is slower than "
                                  + abstractSportsCar.GetType().Name);
            }
        }

        private class AudiSportsCar : SportsCar
        {
        }

        private class AudiFamilyCar : FamilyCar
        {
            public override void Speed(SportsCar abstractSportsCar)
            {
                Console.WriteLine(GetType().Name + " is slower than "
                                  + abstractSportsCar.GetType().Name);
            }

            //}
            //public class Driver
            //{
            //    private SportsCar _sportsCar;
            //    private FamilyCar _familyCar;

            //    public Driver(CarFactory carFactory)
            //    {
            //        _sportsCar = carFactory.CreateSportsCar();
            //        _familyCar = carFactory.CreateFamilyCar();
            //    }

            //    public void CompareSpeed()
            //    {
            //        _familyCar.Speed(_sportsCar);
            //    }
            //}
            public class Driver
            {
                private CarFactory _carFactory;
                private SportsCar _sportsCar;
                private FamilyCar _familyCar;

                public Driver(CarFactory carFactory)
                {
                    CarFactory = carFactory;
                    SportsCar = CarFactory.CreateSportsCar();
                    FamilyCar = CarFactory.CreateFamilyCar();
                }

                private CarFactory CarFactory
                {
                    get { return _carFactory; }
                    set { _carFactory = value; }
                }

                private SportsCar SportsCar
                {
                    get { return _sportsCar; }
                    set { _sportsCar = value; }
                }

                private FamilyCar FamilyCar
                {
                    get { return _familyCar; }
                    set { _familyCar = value; }
                }

                public void CompareSpeed()
                {
                    FamilyCar.Speed(SportsCar);
                }
            }




        }
    }
}
