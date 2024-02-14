using Interfaces;
using Interfaces.Business.Abstracts;
using Interfaces.Business.Concrete;

IPersonManger customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

IPersonManger employeeManager = new EmployeeManager();
employeeManager.Add();
employeeManager.Update();

var projectManager = new ProjectManager();
projectManager.Add(new CustomerManager());
projectManager.Add(new EmployeeManager());
projectManager.Add(new InternManager());