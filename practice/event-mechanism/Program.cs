using System;

namespace EventMechanismDemo
{
    // Step 1: Declare the delegate
    delegate void EventDelegate(object sender, EventArgs e);

    // Step 7: Define the class for sending the data
    class EventSenderArgs : EventArgs
    {
        public int data;
        public EventSenderArgs(int value)
        {
            data = value;
        }
    }

    // Step 2: Identify the Event Sender and Event Receiver class
    class EventSender
    {
        // Step 3: Define the event in Event Sender class
        public event EventDelegate eventVar;
        public void RaiseEvent()
        {
            // Step 8: Raise the event
            Console.WriteLine("Raising event...");
            eventVar(this, new EventSenderArgs(5));
        }
    }

    // Step 2: Identify the Event Sender and Event Receiver class
    class EventReceiver
    {
        // Step 4: Define the method to handle the event in Event Receiver class
        public void EventHandler1(object sender, EventArgs e)
        {
            Console.WriteLine("Inside EventHandler1()");
        }

        // Step 4: Define the method to handle the event in Event Receiver class    
        public void EventHandler2(object sender, EventArgs e)
        {
            Console.WriteLine("Inside EventHandler2()");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Step 5: Create the object of Event Sender class
            EventSender eventSenderObj = new EventSender();
            EventReceiver eventReceiverObj = new EventReceiver();

            // Step 6: Subscribe/Unsubscribe from the event
            eventSenderObj.eventVar += new EventDelegate(eventReceiverObj.EventHandler1);
            // Step 8: Raise the event
            eventSenderObj.RaiseEvent();

            // Step 6: Subscribe/Unsubscribe from the event
            eventSenderObj.eventVar += new EventDelegate(eventReceiverObj.EventHandler2);
            // Step 8: Raise the event
            eventSenderObj.RaiseEvent();

            // Step 6: Subscribe/Unsubscribe from the event
            eventSenderObj.eventVar -= new EventDelegate(eventReceiverObj.EventHandler2);
            // Step 8: Raise the event
            eventSenderObj.RaiseEvent();
        }
    }
}
