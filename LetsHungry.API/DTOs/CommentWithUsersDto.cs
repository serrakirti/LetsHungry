namespace LetsHungry.API.DTOs
{
    public class CommentWithUsersDto:CommentDto
    {
        public UserDto User { get; set; }
    }
}
