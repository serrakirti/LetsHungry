namespace LetsHungry.API.DTOs
{
    public class UserWithCommentsDto:UserDto
    {
        public ICollection<UserDto> Users { get; set; }

    }
}
