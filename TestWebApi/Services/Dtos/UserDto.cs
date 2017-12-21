namespace TestWebApi.Services.Dtos
{
    public class UserDto
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}