﻿namespace LetsHungry.API.DTOs
{
    public class UserWithCommentsDto:UserDto
    {
        public ICollection<CommentDto> Comments { get; set; }

    }
}
