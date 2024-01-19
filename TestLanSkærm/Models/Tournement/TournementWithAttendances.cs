namespace TestLanSkærm.Models.Tournement
{
	public class TournementWithAttendances
	{
		public class Tournement
		{
			public string Name { get; set; }
			public Attendance Attendances { get; set; }
		}

		public class Attendance
		{
			public SignUps SignUps { get; set; }
		}

		public class SignUps
		{
			public LineUps LineUps { get; set; }
		}
		public class LineUps
		{
			public string Name { get; set; }
			public Members Members { get; set; }
		}
		public class Members
		{
			public string Role { get; set; }
			public User User { get; set; }
		}

		public class User
		{
			public string Username { get; set; }
		}
	}
}
