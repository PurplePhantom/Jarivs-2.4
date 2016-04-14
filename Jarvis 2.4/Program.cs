using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Threading;

namespace Jarvis_2._0
{
    class Program
    {

        ///making a void that will take the impute of a statment then it will speak this statment and then write it and then a impute to a thread.sleep line to pause the program                                          ///synth,statment,int
        ///synth diclares the spech synthisizer that should beused to speak statment
        ///statment is a line that will writen and spoke 
        ///int is a number stored in millisecond form to pass to a Thred.Sleep
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        static void speakAndWait(SpeechSynthesizer synth, String statement, int millisecondtowait)
        {
            Console.WriteLine(statement);
            synth.Speak(statement);
            Thread.Sleep(millisecondtowait);
        }
        //This code will pass a statement and int write the statement on screen and sleep the program for the int(milliseconds)
        static void writeAndWait(String statement, int millisecondsToWait)
        {
            Console.WriteLine(statement);
            Thread.Sleep(millisecondsToWait);
            return;
        }
        ///it is a simple count down three two one and then then ten seconds used for inhalers
        static void speakAbuterolCountdown(SpeechSynthesizer synth)
        {
            speakAndWait(synth, "starting count down for albuterol", 1000);///1 seconds
            writeAndWait("three", 800);
            writeAndWait("two", 800);
            writeAndWait("one", 800);
            speakAndWait(synth, "puff", 12000);///twelve seconds because it takes time to do the puff and it wount kill you if you hold your breath to long
            speakAndWait(synth, "your ten seconds are up.", 1000);
            return;
        }
        /// This is the same as the speakAbuterolCountdown however it runs for flowvent  
        static void speakfloweventcountdawn(SpeechSynthesizer synth)
        {
            speakAndWait(synth, "starting count down for flow vent", 2000);///2 seconds
            writeAndWait("three", 800);
            writeAndWait("two", 800);
            writeAndWait("one", 800);
            speakAndWait(synth, "puff", 12000);///twelve seconds because it takes time to do the puff and it wount kill you if you hold your breath to long
            speakAndWait(synth, "your ten seconds are up.", 1000);
            return;
        }
        static void Main()
        {
            writeAndWait("Getting albuterol y/n", 100);
            writeAndWait("Timer for albuterol = y/n", 100);
            writeAndWait("Getting salene = y/n", 100);
            writeAndWait("Getting Pulmozyme = y/n", 100);
            writeAndWait("Salene runtime 30 minutes = y/n", 100);
            writeAndWait("Salene runtime 20 minutes = y/n", 100);
            writeAndWait("vest runtime 30 minutes = y/n", 100);
            writeAndWait("Pulmozyme runtime 10 minutes = y/n", 100);
            writeAndWait("Pulmozyme runtime 15 minutes = y/n", 100);
            writeAndWait("shutdown warning 5 minutes = y/n", 100);
            writeAndWait("shutdown warning 10 minutes = y/n", 100);
            writeAndWait("Getting Cayston, and running Cayston = y/n", 100);
            writeAndWait("Getting tobie = y/n", 100);
            writeAndWait("Tobie runtime 25 minutes = y/n", 100);
            writeAndWait("Tobie rintime 30 minutes = y/n", 100);
            //defining all used variables must imputer for each
            ConsoleKeyInfo KIGA = Console.ReadKey();
            ConsoleKeyInfo KIAT = Console.ReadKey();
            ConsoleKeyInfo KIGS = Console.ReadKey();
            ConsoleKeyInfo KIGP = Console.ReadKey();
            ConsoleKeyInfo KISRTL = Console.ReadKey();
            ConsoleKeyInfo KISRTS = Console.ReadKey();
            ConsoleKeyInfo KIVRTS = Console.ReadKey();
            ConsoleKeyInfo KIPRTS = Console.ReadKey();
            ConsoleKeyInfo KIPRTL = Console.ReadKey();
            ConsoleKeyInfo KISDWS = Console.ReadKey();
            ConsoleKeyInfo KISDWL = Console.ReadKey();
            ConsoleKeyInfo KIC = Console.ReadKey();
            ConsoleKeyInfo KIGT = Console.ReadKey();
            ConsoleKeyInfo KITRTS = Console.ReadKey();
            ConsoleKeyInfo KITRTL = Console.ReadKey();
            Thread.Sleep(5000);

            if (KIGA.KeyChar == 'y')
            {
                //reminds user to get inhaler from cabnet
                speakAndWait(synth, "okay please go get your albuterol inhaler", 6000);
            }
            else
            {
            }
            if (KIAT.KeyChar == 'y')
            {
                writeAndWait("starting timers for albuterol.", 5000);
                speakAbuterolCountdown(synth);//a three two one count down for doing albutrol and then a 12 second silent timer
                speakAbuterolCountdown(synth);//"
            }
            else
            {
            }
            if (KIGS.KeyChar == 'y')
            {
                speakAndWait(synth, "please go get your salene and put it in a nebulizer", 15000);

            }
            else
            {
            }

            if (KIGP.KeyChar == 'y')
            {
                speakAndWait(synth, "please go get your pulmozyme and put it next to your chair or in a pocket", 20000);
            }
            else
            {
            }
            if (KISRTL.KeyChar == 'y')
            {
                speakAndWait(synth, "okay please start your salene I will remind you that it is done in 30 minutes", 10000);
            }
            else
            {
            }
            if (KISRTS.KeyChar == 'y')
            {
                speakAndWait(synth, "okay please start you salene I will remind you that it is done in 20 minutes", 10000);

            }
            else
            {
            }
            if (KIVRTS.KeyChar == 'y')
            {
                Thread.Sleep(10000);
                speakAndWait(synth, "Okay now can you please start your vest I will remind you to check it in 15 minutes and tell you that it should be done in 30", 900000);//15 min
                speakAndWait(synth, "please check your vest it should be on point three or four", 300000);//5 min
                if (KISRTS.KeyChar == 'y')
                {
                    speakAndWait(synth, "okay your salene should be done now", 5000);
                    if (KIPRTS.KeyChar == 'y')
                    {
                        speakAndWait(synth, "could you please start pulmozyme I will remind you in ten minutes that it should be done", 300000);//5 min
                        speakAndWait(synth, "your vest should be done by now", 300000);//five minutes
                        speakAndWait(synth, "your pulmozym should be done by now", 60000);

                    }
                    if (KIPRTL.KeyChar == 'y')
                    {
                        speakAndWait(synth, "could you please start pulmozyme I will remind you in 15 minutes that it should be done", 300000);//5 min
                        speakAndWait(synth, "your vest should be done by now", 600000);//ten minutes
                        speakAndWait(synth, "your pulmozym should be done by now", 60000);
                    }
                }
                if (KISRTL.KeyChar == 'y')
                {
                    Thread.Sleep(300000);//5 min
                    speakAndWait(synth, "okay your salene should be done now", 5000);
                    if (KIPRTS.KeyChar == 'y')
                    {
                        speakAndWait(synth, "could you please start pulmozyme I will remind you in ten minutes that it should be done", 30000);
                        speakAndWait(synth, "your vest should be done by now", 600000);//ten minutes
                        speakAndWait(synth, "your pulmozym should be done by now", 60000);

                    }
                    if (KIPRTL.KeyChar == 'y')
                    {
                        speakAndWait(synth, "could you please start pulmozyme I will remind you in 15 minutes that it should be done", 30000);
                        speakAndWait(synth, "your vest should be done by now", 900000);//15 minutes
                        speakAndWait(synth, "your pulmozym should be done by now", 60000);
                    }
                }


            }
            if (KITRTS.KeyChar == 'y')
            {
                speakAndWait(synth, "could you please start tobie i will remind you that it should be done in 25 minutes", 1500000);
                speakAndWait(synth, "okay your tobie should be done by now", 5000);
            }
            if (KITRTL.KeyChar == 'y')
            {
                speakAndWait(synth, "please start your tobie it should be done in about 30 minutes and I will remind you then", 1800000);
                speakAndWait(synth, "okay your tobie should be done by now", 5000);
            }
            if (KISDWS.KeyChar == 'y')
            {
                speakAndWait(synth, "please start shuting off the computer, you have five minutes", 150000);
                writeAndWait("you have used 2.5 minutes of your time", 150000);
                speakAndWait(synth, "okay now that you are off the computer would you please go put your nebulizer in water", 100000);
                writeAndWait("And blood ell man wait for hot water", 400000);
            }
            if (KISDWL.KeyChar == 'y')
            {
                speakAndWait(synth, "would you please chut down your computer in the next ten minutes?", 300000);
                writeAndWait("you have used 5 minutes of your time", 300000);
                speakAndWait(synth, "okay now that you are off the computer would you please go put your nebulizer in water", 100000);
                writeAndWait("and blood hell man wait for hot water", 400000);
            }

            if (KIC.KeyChar == 'y')
            {
                writeAndWait("no that you are off the computer and have your nebulizer in water we can move on", 5000);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("  _0 ");
                Console.WriteLine("/ /`_");
                Console.WriteLine("_/` ");
                Console.WriteLine("  /");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                speakAndWait(synth, "would you please go get your kayston and mix it", 180000);
                speakAndWait(synth, "now that Kayston is mixed, go find your controler please and push a key when you find it", 0);
                ConsoleKeyInfo KI = Console.ReadKey();
                Console.WriteLine("you seem to like the key{0}", KI);
                Thread.Sleep(3000);
                speakAndWait(synth, "please start you cayston and i will come back when it is done it four minutes", 240000);
                speakAndWait(synth, "now that cayston is done please add its nebulizer to the bowl of hot water and you are done for now", 2000);
                writeAndWait("remeber to wash your face and brush your teath, also dont stay up too late", 1000);

            }
        }
    }
}