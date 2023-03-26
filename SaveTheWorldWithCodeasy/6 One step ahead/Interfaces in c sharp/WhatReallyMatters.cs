using System;

namespace Interfaces
{
    public interface IMainThingsInLife
    {
        string IceCream { get; }
        string VideosWithKittens { get; }

        void GoForAWalk();
        void Love();
        void BeAFriend();
    }

    public class WhatReallyMatters
    {
        public static void Main()
        {
            Console.WriteLine("This is my wisdom.");
        }
    }
}