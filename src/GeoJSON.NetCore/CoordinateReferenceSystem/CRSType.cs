﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CRSType.cs" company="Joerg Battermann">
//   Copyright © Joerg Battermann 2014
// </copyright>
// <summary>
//   Defines the GeoJSON Coordinate Reference System Objects (CRS) types as defined in the <see cref="http://geojson.org/geojson-spec.html#coordinate-reference-system-objects">geojson.org v1.0 spec</see>.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace GeoJSON.Net.CoordinateReferenceSystem
{
    /// <summary>
    ///     Defines the GeoJSON Coordinate Reference System Objects (CRS) types as defined in the
    ///     <see cref="http://geojson.org/geojson-spec.html#coordinate-reference-system-objects">geojson.org v1.0 spec</see>.
    /// </summary>
    public enum CRSType
    {
        /// <summary>
        ///     Defines a CRS type where the CRS cannot be assumed
        /// </summary>
        [EnumMember(Value = "unspecified")]
        Unspecified,

        /// <summary>
        ///     Defines the <see cref="http://geojson.org/geojson-spec.html#named-crs">Named</see> CRS type.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,

        /// <summary>
        ///     Defines the <see cref="http://geojson.org/geojson-spec.html#linked-crs">Linked</see> CRS type.
        /// </summary>
        [EnumMember(Value = "link")]
        Link
    }
}