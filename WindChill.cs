// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
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
    /// a class for calculating a wind chill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// a method find wind chill accepts the inputs t and v from the user and calculates the wind chill
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="v">The v.</param>
        public void Findwindchill(double t, double v)
        {
            Utility u = new Utility();
            u.Windchill(t, v);
        }
    }
}
