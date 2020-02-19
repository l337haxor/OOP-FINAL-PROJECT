
using System;
using System.Collections; 

namespace ClassLibrary
{
    /// <summary>
    /// A class that provides a way to customize the sort order of a collection of CartesianPoints. Used in conjunction with the Array.Sort and Array.BinarySearch methods.
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.collections.icomparer%28v=vs.110%29.aspx"/>
    public class CardComparer : IComparer
    {
        /// <summary>
        /// A static interface variable to a new instance.
        /// </summary>
        public static IComparer Default = new CardComparer();

        /// <summary>
        /// Compares two CartesianPoint objects. Required by IComparer interface.
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

                    if((left as Card).rank != (right as Card).rank)
                    {
                        //set the return value to the difference between the x values
                        difference = (left as Card).GetRank() - (right as Card).GetRank();
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

