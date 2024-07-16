namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        /// <summary>
        /// List of one or more semi-colon separated authors 
        /// </summary>
        public string Authors { get; set; }
        /// <summary>
        /// List of one or more semi-colon separated tags string
        /// </summary>
        public string Tags {  get; set; }
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public DateTime? PublishDate { get; set; }




    }
}
