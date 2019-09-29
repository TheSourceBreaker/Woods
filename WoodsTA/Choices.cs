using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsTA
{ 
    public class Choices
    {
        protected string[] deathCount = new string[5];
        //static protected string read = Console.ReadLine().ToLower();
        protected Program program = new Program();
        public string read = Console.ReadLine().ToLower();
        virtual public void Route()
        {

        }
    }

    class Consequence : Choices
    {
        public Consequence()
        {
            deathCount[0] = @"death1.txt";
            deathCount[1] = @"death2.txt";
            deathCount[2] = @"death2.txt";
            deathCount[3] = @"death3.txt";
            deathCount[4] = @"death4.txt";

        }

    }

    class Achievements : Choices
    {
        override public void Route()
        {
            if (read == "route2")
            {
                Console.WriteLine(@"route2.txt");
                Player.playerLocation = "Route2";
                Console.ReadLine();
                if (read == "advance" && Player.playerLocation == "Route2")
                {
                    Console.WriteLine(@"route2a.txt");
                    Player.playerLocation = "Route2a";
                }
            }


            if (read == "route3")
            {
                Console.WriteLine(@"route3.txt");
                Player.playerLocation = "Route3";
                Console.ReadLine();
                if (read == "advance" && Player.playerLocation == "Route3")
                {
                    Console.WriteLine(@"route3a.txt");
                    Player.playerLocation = "Route3a";
                    Player.memoryShards++;

                }
            }

           

            if (read == "route4") 
            {
                Console.WriteLine(@"route4.txt");
                Player.playerLocation = "Route4";
                Console.ReadLine();
                if(read == "advance left" && Player.playerLocation == "Route4")
                {
                    Console.WriteLine(@"route4a.txt");
                    Player.playerLocation = "Route4a";
                    Player.Items++;
                }

                else if (read == "advance right" && Player.playerLocation == "Route4")
                {
                    Console.WriteLine(@"route4b.txt");
                    Player.playerLocation = "Route4b";
                    //This route kills the player
                }
            }

            

            if (read == "route5") 
            {
                Console.WriteLine(@"route5.txt");
                Player.playerLocation = "Route5";
                Console.ReadLine();
                if(read == "advance left" && Player.playerLocation == "Route5")
                {
                    Console.WriteLine(@"route5a.txt");
                    Player.playerLocation = "Route5a";
                    Console.ReadLine();
                    if (read == "advance" && Player.playerLocation == "Route5a")
                    {
                        Console.WriteLine(@"route5c.txt");
                        Player.playerLocation = "Route5c";

                    }
                }
                else if(read == "advance right" && Player.playerLocation == "Route5")
                {
                    Console.WriteLine(@"route5b.txt");
                    Player.playerLocation = "Route5b";
                    //This will kill the player
                }
                
            }


            if (read == "route1" && Player.playerLocation == "Route5c") 
            {
                Console.WriteLine(@"Caveroute1.txt");
                Player.playerLocation = "Caveroute1";
                Console.ReadLine();
                if (read == "advance" && Player.playerLocation == "Caveroute1")
                {
                    Console.WriteLine(@"Caveroute1a.txt");
                    Player.playerLocation = "Caveroute1a";
                    Console.ReadLine();
                    if (read == "advance" && Player.playerLocation == "Caveroute1a")
                    {
                        Console.WriteLine(@"Caveroute1b.txt");
                        Player.playerLocation = "Caveroute1b";
                        Console.ReadLine();
                        if (read == "advance right" && Player.playerLocation == "Caveroute1b")
                        {
                            Console.WriteLine(@"Caveroute1c.txt");
                            Player.playerLocation = "Caveroute1c";
                            Console.ReadLine();
                            if (read == "advance" && Player.playerLocation == "Caveroute1c")
                            {
                                Console.WriteLine(@"Caveroute1e.txt");
                                Player.playerLocation = "Caveroute1e";
                                Console.ReadLine();
                                if (read == "advance" && Player.playerLocation == "Caveroute1e")
                                {
                                    Console.WriteLine(@"Caveroute1f.txt");
                                    Player.playerLocation = "Caveroute1f";
                                    Console.ReadLine();
                                    if (read == "advance right" && Player.playerLocation == "Caveroute1f")
                                    {
                                        Console.WriteLine(@"Caveroute1g.txt");
                                        Player.playerLocation = "Caveroute1g";
                                        //This kills the player
                                    }
                                    else if (read == "advance" && Player.playerLocation == "Caveroute1f")
                                    {
                                        Console.WriteLine(@"Caveroute1h.txt");
                                        Player.playerLocation = "Caveroute1h";
                                        Console.ReadLine();
                                        if (read == "advance" && Player.playerLocation == "Caveroute1h")
                                        {
                                            Console.WriteLine(@"Caveroute1i.txt");
                                            Player.playerLocation = "Caveroute1i";
                                            Console.ReadLine();
                                            if (read == "advance" && Player.playerLocation == "Caveroute1i")
                                            {
                                                Console.WriteLine(@"Caveroute1j.txt");
                                                Player.playerLocation = "Caveroute1j";
                                                Console.ReadLine();
                                                if (read == "advance" && Player.playerLocation == "Caveroute1j")
                                                {
                                                    Console.WriteLine(@"Caveroute1k.txt");
                                                    Player.playerLocation = "Caveroute1k";
                                                    Console.ReadLine();
                                                    if (read == "advance" && Player.playerLocation == "Caveroute1k")
                                                    {
                                                        Console.WriteLine(@"Caveroute1l.txt");
                                                        Player.playerLocation = "Caveroute1l";
                                                        Console.ReadLine();
                                                        if (read == "advance" && Player.playerLocation == "Caveroute1l")
                                                        {
                                                            Console.WriteLine(@"Caveroute1m.txt");
                                                            Player.playerLocation = "Caveroute1m";
                                                            Console.ReadLine();
                                                            if (read == "advance left" && Player.playerLocation == "Caveroute1m")
                                                            {
                                                                Console.WriteLine(@"Caveroute1n.txt");
                                                                Player.playerLocation = "Caveroute1n";
                                                                //This kills the player
                                                            }
                                                            else if (read == "advance right" && Player.playerLocation == "Caveroute1m")
                                                            {
                                                                Console.WriteLine(@"Caveroute1o.txt");
                                                                Player.playerLocation = "Caveroute1o";
                                                                Console.ReadLine();
                                                                if (read == "advance right" && Player.playerLocation == "Caveroute1o")
                                                                {
                                                                    Console.WriteLine(@"Caveroute1p.txt");
                                                                    Player.playerLocation = "Caveroute1p";
                                                                    Console.ReadLine();
                                                                    if (read == "advance right" && Player.playerLocation == "Caveroute1p")
                                                                    {
                                                                        Console.WriteLine(@"Caveroute1q.txt");
                                                                        Player.playerLocation = "Caveroute1q";
                                                                        Console.ReadLine();
                                                                        if (read == "advance" && Player.playerLocation == "Caveroute1q")
                                                                        {
                                                                            Console.WriteLine(@"Caverouteboss1.txt");
                                                                            Player.playerLocation = "Caverouteboss1";
                                                                            

                                                                        }
                                                                    }
                                                                }
                                                            }

                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                        else if (read == "advance left" && Player.playerLocation == "Caveroute1b")
                        {
                            Console.WriteLine(@"Caveroute1d.txt");
                            Player.playerLocation = "Caveroute1d";
                            
                            //This will kill the player
                        }
                    }
                }
            }

            if (read == "route2" && Player.playerLocation == "Route5c")
            {
                Console.WriteLine(@"Caveroute2.txt");
                Player.playerLocation = "Caveroute2";
                Console.ReadLine();
                if (read == "advance" && Player.playerLocation == "Caveroute2")
                {
                    Console.WriteLine(@"Caveroute2a.txt");
                    Player.playerLocation = "Caveroute2a";
                    Console.ReadLine();
                    if (read == "advance" && Player.playerLocation == "Caveroute2")
                    {
                        Console.WriteLine(@"Caveroute2a.txt");
                        Player.playerLocation = "Caveroute2a";
                        Console.ReadLine();
                        if (read == "advance" && Player.playerLocation == "Caveroute2a")
                        {
                            Console.WriteLine(@"Caveroute2ab.txt");
                            Player.playerLocation = "Caveroute2b";
                            Console.ReadLine();
                            if (read == "advance" && Player.playerLocation == "Caveroute2b")
                            {
                                Console.WriteLine(@"Caveroute2c.txt");
                                Player.playerLocation = "Caveroute2c";
                                //This will kill the player
                            }
                            else if (read == "advance" && Player.playerLocation == "Caveroute2b")
                            {
                                Console.WriteLine(@"Caveroute2d.txt");
                                Player.playerLocation = "Caveroute2d";
                                Console.ReadLine();
                                if (read == "advance" && Player.playerLocation == "Caveroute2d")
                                {
                                    Console.WriteLine(@"Caveroute2e.txt");
                                    Player.playerLocation = "Caveroute2e";
                                    Console.ReadLine();
                                    if (read == "advance" && Player.playerLocation == "Caveroute2e")
                                    {
                                        Console.WriteLine(@"Caveroute2f.txt");
                                        Player.playerLocation = "Caveroute2f";
                                        Console.ReadLine();
                                        if (read == "advance right" && Player.playerLocation == "Caveroute2f")
                                        {
                                            Console.WriteLine(@"Caveroute2g.txt");
                                            Player.playerLocation = "Caveroute2g";
                                            //This will kill the player


                                        }
                                        else if (read == "advance left" && Player.playerLocation == "Caveroute2f")
                                        {
                                            Console.WriteLine(@"Caveroute2h.txt");
                                            Player.playerLocation = "Caveroute2h";
                                            Console.ReadLine();
                                            if (read == "advance" && Player.playerLocation == "Caveroute2h")
                                            {
                                                Console.WriteLine(@"Caveroute2i.txt");
                                                Player.playerLocation = "Caveroute2i";
                                                Console.ReadLine();
                                                if (read == "advance" && Player.playerLocation == "Caveroute2i")
                                                {
                                                    Console.WriteLine(@"Caveroute2j.txt");
                                                    Player.playerLocation = "Caveroute2j";
                                                    Console.ReadLine();
                                                    if (read == "advance" && Player.playerLocation == "Caveroute2j")
                                                    {
                                                        Console.WriteLine(@"Caveroute2k.txt");
                                                        Player.playerLocation = "Caveroute2k";
                                                        Console.ReadLine();
                                                        if (read == "advance" && Player.playerLocation == "Caveroute2k")
                                                        {
                                                            Console.WriteLine(@"Caveroute2l.txt");
                                                            Player.playerLocation = "Caveroute2l";
                                                            Console.ReadLine();
                                                            if (read == "advance" && Player.playerLocation == "Caveroute2l")
                                                            {
                                                                Console.WriteLine(@"Caveroute2m.txt");
                                                                Player.playerLocation = "Caveroute2m";
                                                                Console.ReadLine();
                                                                if (read == "advance left" && Player.playerLocation == "Caveroute2m")
                                                                {
                                                                    Console.WriteLine(@"Caveroute2n.txt");
                                                                    Player.playerLocation = "Caveroute2n";
                                                                    //This will kill the player

                                                                }
                                                                else if (read == "advance right" && Player.playerLocation == "Caveroute2m")
                                                                {
                                                                    Console.WriteLine(@"Caveroute2o.txt");
                                                                    Player.playerLocation = "Caveroute2o";
                                                                    Console.ReadLine();
                                                                    if (read == "advance" && Player.playerLocation == "Caveroute2o")
                                                                    {
                                                                        Console.WriteLine(@"Caveroute2p.txt");
                                                                        Player.playerLocation = "Caveroute2p";
                                                                        Console.ReadLine();
                                                                        if (read == "advance" && Player.playerLocation == "Caveroute2p")
                                                                        {
                                                                            Console.WriteLine(@"Caveroute2q.txt");
                                                                            Player.playerLocation = "Caveroute2q";
                                                                            Console.ReadLine();
                                                                            if (read == "advance" && Player.playerLocation == "Caveroute2q")
                                                                            {
                                                                                Console.WriteLine(@"Caverouteboss1.txt");
                                                                                Player.playerLocation = "Caverouteboss1";
                                                                                


                                                                            }


                                                                        }


                                                                    }


                                                                }


                                                            }


                                                        }


                                                    }


                                                }


                                            }

                                        }

                                    }

                                }

                            }

                        }
                    }
                }
            }


            if (read == "attack" && Player.playerLocation == "Caverouteboss1") 
            {
                Console.WriteLine(@"Cavequestion.txt");
                Console.ReadLine();
                if(read == @"Boss1Answer1")
                {
                    Console.WriteLine("Miss*");
                    Console.WriteLine(@"Cavequestion2.txt");
                    Console.ReadLine();
                    if (read == @"BossAnswer2")
                    {
                        Console.WriteLine("Miss*");
                        Console.WriteLine(@"Cavequestion3.txt");
                        Console.ReadLine();
                        if(read == @"BossAnswer3")
                        {
                            Console.WriteLine("Miss*");
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if(read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if(read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if(read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if(read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hit*");
                            Player.playerhealth--;
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hit*");
                        Player.playerhealth--;
                        Console.WriteLine(@"Cavequestion3.txt");
                        Console.ReadLine();
                        if (read == @"BossAnswer3")
                        {
                            Console.WriteLine("Miss*");
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hit*");
                            Player.playerhealth--;
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hit*");
                    Player.playerhealth--;
                    Console.WriteLine(@"Cavequestion2.txt");
                    Console.ReadLine();
                    if (read == @"BossAnswer2")
                    {
                        Console.WriteLine("Miss*");
                        Console.WriteLine(@"Cavequestion3.txt");
                        Console.ReadLine();
                        if (read == @"BossAnswer3")
                        {
                            Console.WriteLine("Miss*");
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hit*");
                            Player.playerhealth--;
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hit*");
                        Player.playerhealth--;
                        Console.WriteLine(@"Cavequestion3.txt");
                        Console.ReadLine();
                        if (read == @"BossAnswer3")
                        {
                            Console.WriteLine("Miss*");
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hit*");
                            Player.playerhealth--;
                            Console.WriteLine(@"Cavequestion4.txt");
                            Console.ReadLine();
                            if (read == @"BossAnswer4")
                            {
                                Console.WriteLine("Miss*");
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Hit*");
                                Player.playerhealth--;
                                Console.WriteLine(@"Cavequestion5.txt");
                                Console.ReadLine();
                                if (read == @"BossAnswer5")
                                {
                                    Console.WriteLine("Miss*");
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //1
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //2
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hit*");
                                    Player.playerhealth--;
                                    Console.WriteLine(@"Cavequestion6.txt");
                                    Console.ReadLine();
                                    if (read == @"BossAnswer6")
                                    {
                                        Console.WriteLine("Miss*");
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                               //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hit*");
                                        Player.playerhealth--;
                                        Console.WriteLine(@"Cavequestion7.txt");
                                        Console.ReadLine();
                                        if (read == @"BossAnswer7")
                                        {
                                            Console.WriteLine("Miss*");
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }                                                                           //3
                                        else
                                        {
                                            Console.WriteLine("Hit*");
                                            Player.playerhealth--;
                                            Console.WriteLine(@"Caveboss2.txt");
                                            Player.playerLocation = "Caveboss2";

                                        }
                                    }

                                }
                            }
                        }
                    }
                }

               
            }

            if (read == "route6" && Player.playerLocation == "Caveboss2") 
            {

            }

            //if (read == "route7") 
            //{

            //}
            //if (read == "route8") 
            //{

            //}

        }
    }
}
