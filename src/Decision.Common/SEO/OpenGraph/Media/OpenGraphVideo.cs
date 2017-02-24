﻿using System.Text;
using Decision.Common.Extensions;

namespace Decision.Common.SEO.OpenGraph.Media
{
    /// <summary>
    ///     A video file that complements this object.
    /// </summary>
    public class OpenGraphVideo : OpenGraphSizedMedia
    {
        #region Public Methods

        /// <summary>
        ///     Appends a HTML-encoded string representing this instance to the <paramref name="stringBuilder" /> containing the
        ///     Open Graph meta tags.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        public override void ToString(StringBuilder stringBuilder)
        {
            stringBuilder.AppendMetaPropertyContent("og:video", Url);
            stringBuilder.AppendMetaPropertyContentIfNotNull("og:video:secure_url", UrlSecure);
            stringBuilder.AppendMetaPropertyContentIfNotNull("og:video:type", Type);
            stringBuilder.AppendMetaPropertyContentIfNotNull("og:video:width", Width);
            stringBuilder.AppendMetaPropertyContentIfNotNull("og:video:height", Height);
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">The video URL.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="videoUrl" /> is <c>null</c>.</exception>
        public OpenGraphVideo(string videoUrl)
            : base(videoUrl)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">The video URL.</param>
        /// <param name="type">
        ///     The MIME type of the video e.g. media/mpg. This is optional if your video URL ends with
        ///     a file extension, otherwise it is recommended.
        /// </param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="videoUrl" /> is <c>null</c>.</exception>
        public OpenGraphVideo(string videoUrl, string type) : this(videoUrl)
        {
            Type = type;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">The video URL.</param>
        /// <param name="width">The width of the video in pixels. This is optional.</param>
        /// <param name="height">The height of the video in pixels. This is optional.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="videoUrl" /> is <c>null</c>.</exception>
        public OpenGraphVideo(string videoUrl, int width, int height) : this(videoUrl)
        {
            Height = height;
            Width = width;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenGraphVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">The video URL.</param>
        /// <param name="type">
        ///     The MIME type of the video e.g. media/mpg. This is optional if your video URL ends with
        ///     a file extension, otherwise it is recommended.
        /// </param>
        /// <param name="width">The width of the video in pixels. This is optional.</param>
        /// <param name="height">The height of the video in pixels. This is optional.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="videoUrl" /> is <c>null</c>.</exception>
        public OpenGraphVideo(string videoUrl, string type, int width, int height) : this(videoUrl, type)
        {
            Height = height;
            Width = width;
        }

        #endregion
    }
}