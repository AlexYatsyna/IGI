using Microsoft.AspNetCore.Identity;

namespace WEB_953506_YATSYNA
{
    public class ApplicationUser:IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}