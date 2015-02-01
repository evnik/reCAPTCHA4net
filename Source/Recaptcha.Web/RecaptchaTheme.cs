// Copyright (c) Eugene Berdnikov. See License.txt in the project root for license information.

using System;

namespace Recaptcha.Web
{
    /// <summary>
    /// Represents the themes used to render the reCAPTCHA HTML.
    /// </summary>
    [Obsolete("Use ColorTheme enumeration to set a color theme, which is supported by the current version of API.")]
    public enum RecaptchaTheme
    {
        /// <summary>
        /// The theme is red.
        /// </summary>
        Red = 0,

        /// <summary>
        /// The theme is black glass.
        /// </summary>
        Blackglass = 1,

        /// <summary>
        /// The theme is white.
        /// </summary>
        White = 2,

        /// <summary>
        /// The theme is clean.
        /// </summary>
        Clean = 3
    }
}
