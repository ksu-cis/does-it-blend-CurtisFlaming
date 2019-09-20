using System;
using System.Collections.Generic;
namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iBlendable> blendables = new List<iBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            blendables.Add(new Mango());

            Banana b = new Banana();
            blendables.Add(b);

            string mess = "";
            foreach (iBlendable o in blendables)
            {
                mess += o.Blend() + " ";
            }
            Console.WriteLine(mess);
        }
    }
}
