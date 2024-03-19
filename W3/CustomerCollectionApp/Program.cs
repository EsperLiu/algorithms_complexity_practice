// See https://aka.ms/new-console-template for more information


using CustomerCollectionApp;

CustomerCollection aCollection = new CustomerCollection();

aCollection.Insert("Morris", "Scott", 11111111);
aCollection.Insert("Turnbull", "Malcolm", 22222222);
aCollection.Insert("Rudd", "Kevin", 33333333);
aCollection.Insert("Gillard", "Julia", 44444444);
aCollection.Insert("Howard", "John", 55555555);

aCollection.Display();
Console.WriteLine();

int mobile = aCollection.Find("Rudd", "Kevin");
Console.WriteLine("The mobile number of Kevin Rudd is " + mobile.ToString());
Console.WriteLine();

aCollection.Delete("Rudd", "Kevin");
aCollection.Display();
Console.WriteLine();

Customer aCustomer = new Customer("Rudd", "Kevin", 33333333);
aCollection.Insert(aCustomer);
aCollection.Display();
Console.WriteLine();

