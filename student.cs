public class student
{
	public int StudentId {get; set;}

	public string StudentName {get; set;}

	public int Age {get; set;} 

	public string Email {get; set;}


	public string GetStudentName()
	{
		return StudentName;
	}

}
