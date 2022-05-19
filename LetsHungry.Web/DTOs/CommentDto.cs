namespace LetsHungry.Web.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CommentDate { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
    }
}
