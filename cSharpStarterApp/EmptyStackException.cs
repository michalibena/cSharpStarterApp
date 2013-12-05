using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpStarterApp
{
    class EmptyStackException : Exception
    {
        // parameterless constructor
        public EmptyStackException()
            : base("Stack is empty")
        {
            // empty constructor
        } // end EmptyStackException constructor

        // one-parameter constructor
        public EmptyStackException(string exception)
            : base(exception)
        {
            // empty constructor
        } // end EmptyStackException constructor

        // two-parameter constructor
        public EmptyStackException(string exception, Exception inner)
            : base(exception, inner)
        {
            // empty constructor
        } // end EmptyStackException constructor
    } // end class EmptyStackException
}
