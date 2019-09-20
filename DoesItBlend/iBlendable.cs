using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// interface for things to blend
    /// </summary>
    public interface iBlendable

    {
        /// <summary>
        /// blends the things
        /// </summary>
        /// <returns>blended things</returns>
        string Blend();

    }
}
