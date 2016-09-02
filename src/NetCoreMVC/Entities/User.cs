using System.ComponentModel.DataAnnotations;

namespace NetCoreMVC.Entities
{
	public class User
    {
		[Key]
		public int u_id { get; set; }
		public string u_name { get; set; }
		public string u_password { get; set; }
    }
}
