using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListSoftware.DataClasses
{
    public class UnitType : Enumeration
    {
        public static readonly UnitType Each = new UnitType(0, "Each");
        public static readonly UnitType Ounces = new UnitType(1, "Ounces");
        public static readonly UnitType Grams = new UnitType(2, "Grams");
        public static readonly UnitType Pounds = new UnitType(3, "Pounds");
        public static readonly UnitType Teaspoons = new UnitType(4, "Teaspoons");
        public static readonly UnitType Tablespoons = new UnitType(5, "Tablespoons");
        public static readonly UnitType Cups = new UnitType(6, "Cups");
        public static readonly UnitType Pinch = new UnitType(7, "Pinch");
        public static readonly UnitType Dab = new UnitType(8, "Dab");
        public static readonly UnitType Pad = new UnitType(9, "Pad");
        public static readonly UnitType FluidOunces = new UnitType(10, "Fluid Ounces");
        public static readonly UnitType Pints = new UnitType(11, "Pints");
        public static readonly UnitType Quarts = new UnitType(12, "Quarts");
        public static readonly UnitType Gallons = new UnitType(13, "Gallons");

        public UnitType(int value, string displayName)
            :base(value, displayName)
        {
            
        }
    }


}
