using WebApiClientConsole;

Console.WriteLine("API CLIENT : ");
EmployeeAPIClient.UpdateEmployee().Wait();
Console.ReadLine();