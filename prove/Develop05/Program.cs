// My program validates when a goals has already been completed and avoids giving the user the points he/she would earn for completing that goal because it was previously completed.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();
        goalManager.Start();
    }
}