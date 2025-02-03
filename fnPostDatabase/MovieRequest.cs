namespace fnPostDatabase
{
    /// <summary>
    /// Representa uma solicitação de filme para ser armazenada no banco de dados.
    /// </summary>
    internal class MovieRequest
    {
        /// <summary>
        /// Obtém o identificador único do filme.
        /// </summary>
        public string Id { get; }

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

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="MovieRequest"/>.
        /// </summary>
        public MovieRequest()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
