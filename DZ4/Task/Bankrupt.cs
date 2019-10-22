using System;
namespace Task
{
    [Serializable]
    class Bankrupt : Exception
    {
        public Bankrupt() : base(String.Format($"You are Bankrupt! Press any key for exit..."))
        {

        }  
    }
}
