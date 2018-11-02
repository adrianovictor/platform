using System;
using Platform.Domain.Common;

namespace Platform.Domain.Model.Users
{
    public class User : Entity<User>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public UserStatus Status { get; set; }

        protected User() { }

        public User(string name, string userName, string email, string password, string image = null, 
            UserStatus status = UserStatus.Active)
        {
            
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeStatus(UserStatus status)
        {

        }

        public void ChangeAvatar(string image)
        {
            Image = image;
        }

        public static User Create(string name, string userName, string email, string password, string image = null,
            UserStatus status = UserStatus.Active)
        {
            return new User(name, userName, email, password, image, status);
        }
    }
}
