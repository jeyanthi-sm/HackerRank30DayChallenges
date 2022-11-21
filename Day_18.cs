
using System.Collections;

class Solution {
       //Write your code here
        Stack x = new Stack();
        Queue xque = new Queue();
        internal void pushCharacter(char ch)
        {
            x.Push(ch);
        }
        internal char popCharacter()
        {
            return (char)x.Pop();

        }
        internal void enqueueCharacter(char c)
        {
            xque.Enqueue(c);
        }
        internal char dequeueCharacter()
        {
            return (char)xque.Dequeue();
        }
