﻿namespace Cake.Common.Tools.XBuild
{
    /// <summary>
    /// Represents a MSBuild tool version.
    /// </summary>
    public enum XBuildToolVersion
    {
        /// <summary>
        /// The highest available MSBuild tool version.
        /// </summary>
        Default = 0,

        /// <summary>
        /// XBuild tool version: <c>.NET 2.0</c>
        /// </summary>
        NET20 = 1,

        /// <summary>
        /// MSBuild tool version: <c>.NET 3.0</c>
        /// </summary>
        NET30 = 1,

        /// <summary>
        /// MSBuild tool version: <c>.NET 3.5</c>
        /// </summary>
        NET35 = 2,

        /// <summary>
        /// MSBuild tool version: <c>.NET 4.0</c>
        /// </summary>
        NET40 = 3,
    }
}