/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Creating a queue with an invalid size (0 or -5).
        // Expected Result: The maximum size should be automatically set to 10.
        Console.WriteLine("Test 1");
        var cs1 = new CustomerService(0);
        Console.WriteLine(cs1);

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        var cs2 = new CustomerService(2);

    Console.SetIn(new StringReader("John\n1001\nInternet Problem\n"));
    cs2.AddNewCustomer();

    Console.SetIn(new StringReader("Mary\n1002\nPassword Reset\n"));
    cs2.AddNewCustomer();

    Console.SetIn(new StringReader("Bob\n1003\nBilling Problem\n"));
    cs2.AddNewCustomer();

    Console.WriteLine(cs2);
        // Defect(s) Found: 

        Console.WriteLine("=================");

            var cs3 = new CustomerService(3);

            // Test 3
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 3");

    Console.SetIn(new StringReader("John\n1001\nInternet Problem\n"));
    cs3.AddNewCustomer();

    Console.SetIn(new StringReader("Mary\n1002\nPassword Reset\n"));
    cs3.AddNewCustomer();

    cs3.ServeCustomer();

    Console.WriteLine(cs3);

     // Test 4
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 4");
        var cs4 = new CustomerService(2);

        cs4.ServeCustomer();

    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

      

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count == 0)
        {
            Console.WriteLine("No customers in the queue.");
            return;
        }else
        {
            var customer = _queue[0];
            _queue.RemoveAt(0);
            Console.WriteLine(customer);
        }

       
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}