using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class ICardComparer : IComparer
    {
        /// <summary>
        /// A static interface variable to a new instance.
        /// </summary>
        public static IComparer Default = new ICardComparer();

        /// <summary>
        /// Compares two Card objects. Required by IComparer interface.
        /// </summary>
        /// <param name="left">An object to compare.</param>
        /// <param name="right">Another object to compare.</param>
        /// <returns>An integer indicating whether the one object precedes, follows, or occurs in the same position in the sort order as the other object.</returns>
        public int Compare(object left, object right)
        {
            if (left is Card)
            {

                if (right is Card)
                {
                    //if all good

                    int difference = 0; //holds the return value

                    if ((left as Card).rank < (right as Card).rank)
                    {
                        //set the return value to the difference between the x values
                        difference = (left as Card).rank - (right as Card).rank;
                    }
                   
                    return difference;
                }
                else
                {
                    throw (new ArgumentException("Cannot compare Card objects with of type: " + right.GetType().ToString() + "."));
                }
            }
            else
            {
                throw (new ArgumentException("Cannot compare Card objects with of type: " + left.GetType().ToString() + "."));
            }
        }
    }
}
