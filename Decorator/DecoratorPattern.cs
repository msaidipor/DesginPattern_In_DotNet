using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    /// <summary>
    /// Base Component Interfase
    /// </summary>
  public interface IRoom
    {
        string GetDescription();
        int GetPrice();
    }


    /// <summary>
    /// Concrete Component
    /// </summary>
    public class SimpleRoom : IRoom
    {
        public string GetDescription()
        {
            return "Base Room";
        }

        public int GetPrice()
        {
            return 1;
        }
    }

    /// <summary>
    /// Base Decorator Class
    /// </summary>
    public abstract class RoomDecorator(IRoom _room): IRoom
    {

        public virtual string GetDescription()
        {
            if (_room != null)
              return  _room.GetDescription();
            else return "";
        }

        public virtual int GetPrice()
        {
            if (_room != null)
              return  _room.GetPrice();
            else return 1;
        }
    }

    /// <summary>
    /// Concrete Decorator
    /// </summary>
    /// <param name="_room"></param>
    public class WifiDecorator(IRoom _room) : RoomDecorator(_room)
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " + Wifi";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 1;
        }
    }

    /// <summary>
    /// Concrete Decorator
    /// </summary>
    /// <param name="_room"></param>
    public class BreakfastDecorator(IRoom _room) : RoomDecorator(_room)
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " + Breakfast";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 2;
        }
    }
}
