﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    //  This class is handling the Babarian character, inherits from ICharacter, IAxe and IBash
    public class Babarian : ICharacter, IAxe, IBash
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}
