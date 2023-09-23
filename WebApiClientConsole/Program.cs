using WebApiClientConsole;

Console.WriteLine("API CLIENT : ");
EmployeeAPIClient.CallGetAllEmployeeJson().Wait();
Console.ReadLine();