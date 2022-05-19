namespace LetsHungry.Web.DTOs
{
    public class CommentWithUsersDto:CommentDto
    {
        public UserDto User { get; set; }
    }
}
