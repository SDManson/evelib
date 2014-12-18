﻿// ***********************************************************************
// Assembly         : EveLib.EveCrest
// Author           : Lars Kristian
// Created          : 12-16-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 12-17-2014
// ***********************************************************************
// <copyright file="CrestResource.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eZet.EveLib.EveCrestModule.Models.Links;

namespace eZet.EveLib.EveCrestModule.Models.Resources {
    /// <summary>
    ///     Class CrestResource.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class CrestResource<T> : ICrestResource<T> where T : class, ICrestResource<T> {
        /// <summary>
        ///     Gets or sets the crest.
        /// </summary>
        /// <value>The crest.</value>
        public EveCrest Crest { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this resource is deprecated.
        /// </summary>
        /// <value><c>true</c> if this instance is deprecated; otherwise, <c>false</c>.</value>
        public virtual bool IsDeprecated { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public virtual string ContentType { get; protected set; }


        /// <summary>
        ///     Queries the resource asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public Task<TOut> QueryAsync<TOut>(Func<T, Href<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return Crest.LoadAsync(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public TOut Query<TOut>(Func<T, Href<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return Crest.Load(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public Task<TOut> QueryAsync<TOut>(Func<T, LinkedEntity<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return Crest.LoadAsync(objFunc.Invoke(this as T));
        }

        /// <summary>
        ///     Queries the resource.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut&gt;.</returns>
        public TOut Query<TOut>(Func<T, LinkedEntity<TOut>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            return Crest.Load(objFunc.Invoke(this as T));
        }

        /// <summary>
        /// Queries a collection of resources asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual Task<IEnumerable<TOut>> QueryAsync<TOut>(Func<T, IEnumerable<Href<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            var items = objFunc.Invoke(this as T);
            return Crest.LoadAsync(items);
        }

        /// <summary>
        /// Queries a collection of resources.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual IEnumerable<TOut> Query<TOut>(Func<T, IEnumerable<Href<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            var items = objFunc.Invoke(this as T);
            return Crest.Load(items);
        }

        /// <summary>
        /// Queries a collection of resources asynchronous.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual Task<IEnumerable<TOut>> QueryAsync<TOut>(Func<T, IEnumerable<LinkedEntity<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            var items = objFunc.Invoke(this as T);
            return Crest.LoadAsync(items);
        }

        /// <summary>
        /// Queries a collection of resources.
        /// </summary>
        /// <typeparam name="TOut">The type of the t out.</typeparam>
        /// <param name="objFunc">The object function.</param>
        /// <returns>Task&lt;TOut[]&gt;.</returns>
        public virtual IEnumerable<TOut> Query<TOut>(Func<T, IEnumerable<LinkedEntity<TOut>>> objFunc)
            where TOut : class, ICrestResource<TOut> {
            var items = objFunc.Invoke(this as T);
            return Crest.Load(items);
        }
    }
}