using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IDeviceFactory
    {
        ILoptopProduct CreateLoptop();
        ITabletProduct CreateTablet();
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class AsusFactory : IDeviceFactory
    {
        public ILoptopProduct CreateLoptop() => new AsusLoptop();

        public ITabletProduct CreateTablet() => new AsusTablet ();
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class DellFactory : IDeviceFactory
    {
        public ILoptopProduct CreateLoptop() => new DellLoptop();

        public ITabletProduct CreateTablet() => new DellTablet();
    }


    /// <summary>
    /// Abstract ProductA
    /// </summary>
    public interface ILoptopProduct
    {
        void TurnOn();
        void PlayMusic();
        void ShutDown();
        
    }

    /// <summary>
    /// Abstract ProductB
    /// </summary>
    public interface ITabletProduct
    {
        void TurnOn();
        void Ring();
        void TurnOff();
    }



    /// <summary>
    /// Concrete ProductA1
    /// </summary>
    public class AsusLoptop : ILoptopProduct
    {
        public void TurnOn() => Console.WriteLine("Asus LopTop TurnOn");
        public void PlayMusic() => Console.WriteLine("Asus LopTop PlayMusic");
        public void ShutDown() => Console.WriteLine("Asus LopTop ShutDown");

    }

    /// <summary>
    /// Concrete ProductA2
    /// </summary>
    public class DellLoptop:ILoptopProduct
    {
        public void TurnOn() => Console.WriteLine("Dell LopTop TurnOn");
        public void PlayMusic() => Console.WriteLine("Dell LopTop PlayMusic");
        

        public void ShutDown() => Console.WriteLine("Dell LopTop ShutDown");

    }

    /// <summary>
    /// Concrete ProductB1
    /// </summary>

    public class AsusTablet : ITabletProduct
    {

        public void TurnOn() => Console.WriteLine("Asus Tablet TurnOn");
        public void Ring() => Console.WriteLine("Asus Tablet Ring");
        public void TurnOff() => Console.WriteLine("Asus Tablet TurnOff");
    }

    /// <summary>
    /// Concrete ProductB2
    /// </summary>

    public class DellTablet : ITabletProduct
    {
  
        public void TurnOn() => Console.WriteLine("Dell Tablet TurnOn");
        public void Ring() => Console.WriteLine("Dell Tablet Ring");
        public void TurnOff() => Console.WriteLine("Dell Tablet TurnOff");
    }



   
}
