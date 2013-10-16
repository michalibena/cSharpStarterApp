using System;

namespace cSharpStarterApp
{
    class Worker
    {
        // class fields/members
        int _count;
        string _message;

        // class properties
        int Count
        //{ get; set;}
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }

        // ctors
        public Worker(int count, string message)
        {
            Count = count;
            Message = message;
        }

        // setters - if not using properties
        //void setMessage(string message) { }
        //void setCount(int count) { }

        // getters - if not using properties
        //int getCount() { return _count; }
        //string getMessage() { return _message; }

        public void doWork()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(i + ": "+ Message);
            }
        }

        public override string ToString()
        {
            string s = base.ToString() + ": Count = " + Count + ", Message = " + Message;
            return s;
        }
    }
}
