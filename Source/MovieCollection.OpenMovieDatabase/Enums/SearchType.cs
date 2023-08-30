﻿namespace MovieCollection.OpenMovieDatabase.Enums
{
    /// <summary>
    /// Specifies search type.
    /// </summary>
    public enum SearchType
    {
        /// <summary>
        /// Movie type can be a movie or a series.
        /// </summary>
        NotSpecified = -1,

        /// <summary>
        /// Only return movies.
        /// </summary>
        Movie = 0,

        /// <summary>
        /// Only return series.
        /// </summary>
        Series = 1,
    }
}
