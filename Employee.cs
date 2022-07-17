namespace CatWorx.BadgeMaker
{
  class Employee
  {
    while (true)
    {
      Console.WriteLine("Please enter a name: (leave empty to exit): ");
      string input = Console.ReadLine();
      if (input == "")
      {
        break;
      }

      // Create a new Employee instance
      Employee currentEmployee = new Employee();
      employees.Add(input);
    }
  }
}