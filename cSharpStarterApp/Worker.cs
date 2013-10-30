using System;
using System.IO;
using System.Text;

namespace cSharpStarterApp
{
    class Worker
    {
        // class fields/members
        int _count;
        string _message;
        FileInfo wFile;
        string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string wFileName;
        StreamWriter outfile;

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
            wFileName = myDocPath + @"\worker.txt";
            wFile = new FileInfo(wFileName);
        }

        // setters - if not using properties
        //void setMessage(string message) { }
        //void setCount(int count) { }

        // getters - if not using properties
        //int getCount() { return _count; }
        //string getMessage() { return _message; }

        public void doWork()
        {
            StringBuilder sb = new StringBuilder();
            outfile = new StreamWriter(wFileName);

            for (int i = 0; i < Count; i++)
            {
                sb.Append(i);
                sb.Append(": ");
                sb.Append(Message);
                Console.WriteLine(sb.ToString());
                outfile.WriteLine(sb.ToString());
                sb.Remove(0, sb.Length);
            }

            outfile.Close();
        }

        public override string ToString()
        {
            string s = base.ToString() + ": Count = " + Count + ", Message = " + Message;
            return s;
        }
    }
}
