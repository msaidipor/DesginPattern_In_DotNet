using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Flyweight
{


    /// <summary>
    /// Flyweight Interface
    /// </summary>
   public interface IFont
    {
        void SetSize(int size);
        void SetStyle(string style);
        void SetColor(string color);
        void Display(string text);
    }


    /// <summary>
    /// Flywieght Factory Class
    /// </summary>
    public class FontFactory
    {
        private Dictionary<string, IFont> flyweights = new Dictionary<string, IFont>();


        public IFont GetFont(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights[key] = new ConcretaFlyweight();
            }
            return flyweights[key];
        }
    }


    /// <summary>
    /// Flyweight Concrete Class
    /// </summary>

    public class ConcretaFlyweight : IFont
    {
        private int size;
        private string style;
        private string color;

        public void SetSize(int size)
        {
            this.size = size;
        }

        public void SetStyle(string style)
        {
            this.style = style;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void Display(string text)
        {
            Console.WriteLine($"Text: '{text}' | Size: {size} | Style: {style} | Color: {color}");
        }
    }

   
}
