using System;
using System.IO; 
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalmanager = new GoalManager();
        goalmanager.DisplayPlayerInfo();
        goalmanager.Start();
        
        
    }
}