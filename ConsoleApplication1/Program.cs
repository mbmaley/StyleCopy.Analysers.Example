﻿// A licence agreement of somekind for some kind of Company

using System;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    //10 rules ----- 1) tabs, 2) header, 3) commas 4) multiple blank lines  5) underscore 6) this.
    //7) OpeningCurlyBracketsMustNotBeFollowedByBlankLine 8) OpeningCurlyBracketsMustNotBePrecededByBlankLine 9) ClosingBracesMustNotBePrecededByBlankLine 10) disposable
    //11) autogenerated
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("");

            //StreamReader reader = new StreamReader("AFile.txt");
        }
    }

    public class ASomething
    {
        //private string _aStringLikeThing;
        public string AThing;

        public ASomething(string aStringLikeThing, string aThing)
        {
            //_aStringLikeThing = aStringLikeThing;
            this.AThing = aThing;
        }

        public string Random()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
            }

            return "fixed " + this.AThing;
        }
    }
}