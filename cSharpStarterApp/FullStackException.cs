using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpStarterApp
{
    class FullStackException : Exception
    {
        // parameterless constructor
        public FullStackException()
            : base("Stack is full")
        {
            // empty constructor
        } // end FullStackException constructor

        // one-parameter constructor
        public FullStackException(string exception)
            : base(exception)
        {
            // empty constructor
        } // end FullStackException constructor

        // two-parameter constructor
        public FullStackException(string exception, Exception inner)
            : base(exception, inner)
        {
            // empty constructor
        } // end FullStackException constructor
    } // end class FullStackException
}
