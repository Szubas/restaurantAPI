namespace RestaurantAPI
{
    public class AuthenticationSettings
    {
        public string JwtKey { get; set; }
        public int JwtExpiresDay { get; set; }
        public string JwtIssuer { get; set; }
    }
}
