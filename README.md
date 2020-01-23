# Advanced C# : Delegates, Multicast Delegates, Events, Exception Handling #
Course link: <https://www.udemy.com/course/draft/1867650>

## Delegates ##
* Refers to a method
* Declaration syntax:  `modifier delegate return_type delegate_name (parameters)`
    * `modifier`: private, protected, public, new, internal
    * `delegate`: derived using `System.Delegate`
    * `return_type`
    * `delegate_name`
    * `parameters`

* Example:
    ```cs
    delegate int AddNumber(int x, int y);
    delegate void Display(string value);
    delegate string GetName();

    //Delegate for methods with same return_type and parameters
    delegate int NumberDelegate(int x, int y);

    int Add(int a, int b);
    int Subtract(int num1, int num2);
    int Multiply(int x, int y);
    int Divide(int x1, int x2);
    int Modulus(int val1, int val2);

    //Delegate for methods with same return_type and parameters
    delegate void DisplayDelegate(string str);

    void PrintStr(string value);
    void ShowIt(string temp);

    //Using delegate
    delegate int OperationDelegate(int x, int y);
    OperationDelegate oprVar = new OperationDelegate(Add);
    int tempVal = oprVar(20, 10);

    ```

* Passing delegate as parameter in method:

    ```cs
        void ShowString(string value, DisplayDelegate disDelStr)
        {
            disDelStr(value);
        }

        delegate void MethodDelegate(string value);
        MethodDelegate displayString = new MethodDelegate(PrintStr);
        ShowString("Hello", displayString);
    ```

* Multicast delegate:
    - A delegate can have multiple methods and they can be invoked using it
    - The return type of all methods should be `void`
    ```cs
        delegate void OperationMulticastDelegate(int x, int y);
        void Add(int a, int b);
        void Subtract(int num1, int num2);
        void Multiply(int x, int y);
        void Divide(int x1, int x2);
        void Modulus(int val1, int val2);

        OperationMulticastDelegate orpMulticastDelegate = new OperationMulticastDelegate(Add);
        orpMulticastDelegate += new OperationMulticastDelegate(Subtract);
        orpMulticastDelegate += new OperationMulticastDelegate(Multiply);
        orpMulticastDelegate += new OperationMulticastDelegate(Divide);
        orpMulticastDelegate += new OperationMulticastDelegate(Modulus);
    ```
    - Removing methods:
    ```cs
        orpMulticastDelegate -= new OperationMulticastDelegate(Divide);
    ```

    - Multicast delegates Invocation:
    ```cs
        orpMulticastDelegate(20, 10);
    ```

## Events ##
- Events are messages raised to notify the object on a particular action
- Event Sender ---> Event Receiver
- Declaration syntax: `event delegate-type event-name`
- Passing data with event: 
    * Data can be passed with event
    * Define a class derived from class `System.EventArgs`
    * Create the instance and pass it with event in Event Sender class
- Event Mechanism: 
    * Step 1: Declare the delegate
    * Step 2: Identify the Event Sender and Event Receiver class
    * Step 3: Define the event in Event Sender class
    * Step 4: Define the method to handle the event in Event Receiver class
    * Step 5: Create the object of Event Sender class
    * Step 6: Subscribe/Unsubscribe from the event
    * Step 7: Define the class for sending the data
    * Step 8: Raise the event


## Exception ##
- Run-time error generates the exception