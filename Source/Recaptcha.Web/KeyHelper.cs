﻿// Copyright (c) Eugene Berdnikov. See License.txt in the project root for license information.

using System;
using System.Configuration;

namespace Recaptcha.Web
{
    internal class KeyHelper
    {
        /// <summary>
        /// Checks if <paramref name="keySource" /> is a settings name and loads the key from application settings.
        /// <para /> Otherwise returns the <paramref name="keySource" />.
        /// </summary>
        /// <param name="keySource">Name of the entry in the settings (if placed into brackets, e.g. {token}) or the key itself.</param>
        /// <returns>Loaded key or <paramref name="keySource" />.</returns>
        internal static string LoadKey(string keySource)
        {
            if (keySource.StartsWith("{", StringComparison.Ordinal) && keySource.EndsWith("}", StringComparison.Ordinal))
            {
                return ConfigurationManager.AppSettings[keySource.Substring(1, keySource.Length - 2)];
            }

            return keySource;
        }
    }
}
