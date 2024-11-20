namespace BloggingPlatform.Models
{
    public class BlogPost
    {
        /// <summary>
        /// Indique l'identifiant d'un post
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Indique titre de post
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Indique contenu de post
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Indique catégorie de post
        /// </summary>
        public string category { get; set; }
      
        /// <summary>
        /// Indique la liste des tags de post
        /// </summary>
        public List<string> Tags { get; set; }

        /// <summary>
        /// Indique la date de création de post
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Indique date de modification de post
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
