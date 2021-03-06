﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Unity.Lifetime;

namespace Unity.RegistrationByConvention
{
    public partial class WithLifetime
    {
        /// <summary>
        /// Returns a <see cref="PerThreadLifetimeManager"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>A per thread lifetime manager.</returns>
        public static LifetimeManager PerThread(Type type)
        {
            return new PerThreadLifetimeManager();
        }
    }
}
