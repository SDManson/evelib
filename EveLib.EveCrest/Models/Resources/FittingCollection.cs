﻿// ***********************************************************************
// Assembly         : EveLib.EveCrest
// Author           : larsd
// Created          : 10-28-2015
//
// Last Modified By : larsd
// Last Modified On : 10-28-2015
// ***********************************************************************
// <copyright file="FittingCollection.cs" company="Lars Kristian Dahl">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Runtime.Serialization;
using eZet.EveLib.EveCrestModule.Models.Links;

namespace eZet.EveLib.EveCrestModule.Models.Resources {

    /// <summary>
    /// Class FittingCollection. This class cannot be inherited.
    /// </summary>
    [DataContract]
    public sealed class FittingCollection : CollectionResource<FittingCollection, FittingCollection.Fitting> {

        /// <summary>
        /// Initializes a new instance of the <see cref="FittingCollection"/> class.
        /// </summary>
        public FittingCollection() {
            ContentType = "application/vnd.ccp.eve.FittingCollection-v1+json";

        }

        /// <summary>
        /// Class Fitting.
        /// </summary>
        [DataContract]
        public class Fitting {

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>The description.</value>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets the fitting identifier.
            /// </summary>
            /// <value>The fitting identifier.</value>
            [DataMember(Name = "fittingID")]
            public long FittingId { get; set; }

            /// <summary>
            /// Gets or sets the items.
            /// </summary>
            /// <value>The items.</value>
            [DataMember(Name = "items")]
            public IReadOnlyCollection<FittingItem> Items { get; set; }
        }

        /// <summary>
        /// Class FittingItem.
        /// </summary>
        [DataContract]
        public class FittingItem {

            /// <summary>
            /// Gets or sets the flag.
            /// </summary>
            /// <value>The flag.</value>
            [DataMember(Name = "flag")]
            public int Flag { get; set; }

            /// <summary>
            /// Gets or sets the quantity.
            /// </summary>
            /// <value>The quantity.</value>
            [DataMember(Name = "quantity")]
            public int Quantity { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>The type.</value>
            [DataMember(Name = "type")]
            public LinkedEntity<ItemType> Type { get; set; }
        }
    }


}
