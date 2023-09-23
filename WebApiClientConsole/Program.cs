using WebApiClientConsole;

Console.WriteLine("API CLIENT : ");
EmployeeAPIClient.FindEmployeeById(7).Wait();
Console.ReadLine();