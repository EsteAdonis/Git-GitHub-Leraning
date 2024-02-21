namespace Git.GitHub.Models
{
	public class User
	{
		public string Id { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public DateTime DateOfBirth { get; set; } = DateTime.Now;
		public bool IsActive { get; set; } = false;
	}
}