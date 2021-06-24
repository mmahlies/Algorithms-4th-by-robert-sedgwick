using System;

namespace CH2
{
    // C# program for above implementation
    using System;
    using System.Collections.Generic;

    class GfG
    {

        // Function to check validity of stack sequence
        static bool validateStackSequence(int[] pushed,
                                            int[] popped, int len)
        {
            //
            ///*
            /// j=0 i=0     len=5
            ///  st => 1                 ... __ ... __ --- __ ... __ ... ___ ===
            /// 
            /// j=0 i=1
            /// st => 1,2
            /// 
            /// j=0 i=2
            /// st => 1,2,3
            /// st => 1,2
            /// j=1
            /// 
            /// j=1 i=3
            /// st=>1,2,4
            ///   */
            ///   
            // maintain count of popped elements
            int j = 0;

            // an empty stack
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < len; i++)
            {
                st.Push(pushed[i]);

                // check if appended value
                // is next to be popped out
                while (st.Count != 0 && j < len &&
                        st.Peek() == popped[j])
                {
                    st.Pop();
                    j++;
                }
            }

            return j == len;
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] pushed = { 1, 2, 3, 4, 5 };
            int[] popped = { 4, 5, 3, 2, 1 };
            int len = pushed.Length;

            Console.WriteLine((validateStackSequence(pushed,
                            popped, len) ? "True" : "False"));
        }
    }

    // This code contributed by Rajput-Ji
}
