// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Euclidian.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class to find the euclidian distance from the origin(0,0) to given point
    /// </summary>
    public class Euclidian
    {
        /// <summary>
        /// a method to find euclidian distance till (x,y) 
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void Euclidiandist(int x, int y)
        {
            Utility u = new Utility();
            u.EuclidianDistance(x, y);
        }
    }
}
