using WebApiClientConsole;

Console.WriteLine("API CLIENT : ");
EmployeeAPIClient.AddNewEmployee().Wait();
Console.ReadLine();