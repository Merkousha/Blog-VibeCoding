namespace Blog.Domain.Interfaces;

public interface IUser
{
    string Id { get; set; }
    string UserName { get; set; }
    string DisplayName { get; set; }
    string Bio { get; set; }
} 