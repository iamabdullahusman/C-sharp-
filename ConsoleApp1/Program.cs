Console.WriteLine(" Concept of OOP in C Sharp");

var p1 = new Person ("Abdullah", "usman", new DateOnly (2000,5,1));
var p2 = new Person ("Abdullah", "usman", new DateOnly (2000,5,1));
List<Person> people = [p1,p2];
Console.WriteLine(people.Count); 
public class Person(string firstname, string lastname, DateOnly birthday){
    
    public string First {get ;} = firstname;
    public string Last {get ;} =lastname;
    public DateOnly Birthday {get ;} =  birthday;

}


