// See https://aka.ms/new-console-template for more information
using FuelStation.EF.Contexts;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Entities;

var userrepo = new UserRepo(new FuelStationContext());
var customerrepo = new CustomerRepo(new FuelStationContext());
var employeerepo = new EmployeeRepo(new FuelStationContext());
var itemrepo = new ItemRepo(new FuelStationContext());
var transactionrepo = new TransactionRepo(new FuelStationContext());


//var transaction = new Transaction()
//{
//    Date = DateTime.Now,
//    EmployeeID = 10004,
//    CustomerID = 2,
//    PaymentMethod = PaymentMethodEnum.Credit_Card,
//    TotalValue = 8.0
//};

//var line1 = new TransactionLine()
//{
//    ItemID = 1,
//    Quantity = 2,
//    ItemPrice = 0.50,
//    NetValue = 1,
//    DiscountPercent = 0.3f,
//    DiscountValue = 1.3,
//    TotalValue = 2
//};
var line3 = new TransactionLine()
{
    ItemID = 1,
    Quantity = 1,
    ItemPrice = 0.75,
    NetValue = 7,
    DiscountPercent = 0.2f,
    DiscountValue = 5.56,
    TotalValue = 2
};

//transaction.TransactionLines.Add(line1);
//transaction.TransactionLines.Add(line2);

//await transactionrepo.AddAsync(transaction);

//var newUser = await employeerepo.GetByIdAsync(2);
var trans = await transactionrepo.GetByIdAsync(1);
////var users = await employeerepo.GetAllAsync();

//var updateTr = trans;
//updateTr.TransactionLines = new List<TransactionLine>();
//updateTr.TransactionLines.Add(line3);
//await transactionrepo.UpdateAsync(trans.ID, updateTr);
await transactionrepo.DeleteAsync(trans.ID);

//var tr = await transactionrepo.GetByIdAsync(1);

//Console.WriteLine($"ID: {tr.ID}, Employee: {tr.Employee.Surname}, Customer: {tr.Customer.Surname}");
//foreach (var line in tr.TransactionLines)
//{
//    Console.WriteLine(line.ID);
//    Console.WriteLine(line.Item.Description);
//}