namespace fnGetMovieDetail
{
    /// <summary>
    /// Representa o resultado de um filme obtido de uma consulta.
    /// </summary>
    internal class MovieResult
    {
        /// <summary>
        /// Obtém ou define o identificador do filme.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Obtém ou define o título do filme.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Obtém ou define o ano de lançamento do filme.
        /// </summary>
        public string? Year { get; set; }

        /// <summary>
        /// Obtém ou define a URL do vídeo do filme.
        /// </summary>
        public string? Video { get; set; }

        /// <summary>
        /// Obtém ou define a URL da miniatura do filme.
        /// </summary>
        public string? Thumb { get; set; }
    }
}