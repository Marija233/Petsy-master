using System.Collections.Generic;
using System.ComponentModel;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public List<Pet> Pets { get; set; }

    public Person()
    {
        Pets = new List<Pet>();
    }

    [DisplayName("Owner's Full Name")]
	public string GetFullName
	{
		get { return String.Format("{0} {1}", Name, Surname); }
	}

}
