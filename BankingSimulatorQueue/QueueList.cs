using System;
using System.Text;

namespace BankingSimulatorQueue
{
    class QueqeList
    {
        // Array declaration
        int[] queueListArray;

        //variables
        int rear;
        int front;

        /// <summary>
        /// Defined parameterized Constructor.
        /// initialised array size 
        /// initialised 0 with rear and front.
        /// </summary>
        public QueqeList(int size)
        {
            queueListArray = new int[size];
            rear = 0;
            front = 0;
        }

        /// <enqueue>
        ///insertAtLast method
        ///inseting values in array using index "rear"
        ///then incrementing rear
        /// </enqueue>
        public void enqueue(int data)
        {
            queueListArray[rear] = data;
            rear += 1;
        }

        /// <dequeue>
        ///removeAtFirst method
        ///incrementing front so user will be removed
        /// </dequeue>
        public void dequeue()
        {
            front += 1;
        }

        // to display list
        public void showQlist()
        {
            for(int i=front;i<rear;i++)
            {
                Console.WriteLine("Current Balance: "+queueListArray[i]);
            }
        }
    }
}
