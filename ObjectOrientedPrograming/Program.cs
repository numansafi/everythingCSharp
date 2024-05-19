using ObjectOrientedPrograming;
// OOP

// An object(instance) of class DateTime has created


var pizzaDay23 = new DateTime(2023, 02, 09);
//Console.WriteLine(pizzaDay23.DayOfWeek);

var pizzaDay24 = pizzaDay23.AddYears(1);
//Console.WriteLine(pizzaDay24.DayOfWeek);

// First class
var rectangle = new Rectangle(10, 5);


//var person = new Person("John", 1991);

// object initialisers
var person = new Person
{
  Name = "John",
  YearOfBirth = 1996
};

// Using static classes
var addNums = Calculator.Add(1,2);


