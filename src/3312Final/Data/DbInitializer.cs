using _3312Final.Data;
using _3312Final.Models;
using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.DbInitializer
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ClimbData.Any())
            {
                return;   // DB has been seeded
            }

            var climbtable = new ClimbData[]
            {
                new ClimbData{Weight=18000,Vfri5=116,Vfri10=110,Vfri15=107,Vclmb=130},
                new ClimbData{Weight=20000,Vfri5=120,Vfri10=112,Vfri15=109,Vclmb=131},
                new ClimbData{Weight=22000,Vfri5=126,Vfri10=118,Vfri15=115,Vclmb=137},
                new ClimbData{Weight=24000,Vfri5=132,Vfri10=123,Vfri15=120,Vclmb=143},
                new ClimbData{Weight=26000,Vfri5=137,Vfri10=128,Vfri15=125,Vclmb=148},
                new ClimbData{Weight=28000,Vfri5=142,Vfri10=134,Vfri15=130,Vclmb=154},
                new ClimbData{Weight=29000,Vfri5=146,Vfri10=137,Vfri15=133,Vclmb=158},
            };
            foreach (ClimbData cd in climbtable)
            {
                context.ClimbData.Add(cd);
            }
            context.SaveChanges();

            //below here I added
            
            
            /*
            var flap5table = new Flap5Landing[]
            {
                new Flap5Landing {Weight = 18000, Vapp = 115, Vref = "", Vga = 109 },
                new Flap5Landing {Weight = 20000, Vapp = 120, Vref = "", Vga = 110 },
                new Flap5Landing {Weight = 22000, Vapp = 126, Vref = "", Vga = 115 },
                new Flap5Landing {Weight = 24000, Vapp = 131, Vref = "", Vga = 120 },
                new Flap5Landing {Weight = 26000, Vapp = 137, Vref = "", Vga = 125 },
                new Flap5Landing {Weight = 28000, Vapp = 142, Vref = "", Vga = 130 },
                new Flap5Landing {Weight = 29000, Vapp = 146, Vref = "", Vga = 134 }
            };
            foreach (Flap5Landing ft in flap5table)
            {
                context.Flap5Landing.Add(ft);
            }
            context.SaveChanges();
            
    */

            var flap10table = new Flap10Landing[]
                {
                new Flap10Landing {Weight = 18000, Vapp = 109, Vref = 108, Vga = 108 },
                new Flap10Landing {Weight = 20000, Vapp = 112, Vref = 112, Vga = 108 },
                new Flap10Landing {Weight = 22000, Vapp = 117, Vref = 117, Vga = 108 },
                new Flap10Landing {Weight = 24000, Vapp = 122, Vref = 122, Vga = 112 },
                new Flap10Landing {Weight = 26000, Vapp = 127, Vref = 127, Vga = 117 },
                new Flap10Landing {Weight = 28000, Vapp = 132, Vref = 132, Vga = 122 },
                new Flap10Landing {Weight = 29000, Vapp = 136, Vref = 136, Vga = 125 }
                };
            foreach (Flap10Landing ftl in flap10table)
            {
                context.Flap10Landing.Add(ftl);
            }
            context.SaveChanges();

            var flap15table = new Flaps15Landing[]
                {
                new Flaps15Landing {Weight = 18000, Vapp = 106, Vref = 105, Vga = 105 },
                new Flaps15Landing {Weight = 20000, Vapp = 106, Vref = 106, Vga = 105 },
                new Flaps15Landing {Weight = 22000, Vapp = 112, Vref = 112, Vga = 105 },
                new Flaps15Landing {Weight = 24000, Vapp = 117, Vref = 117, Vga = 107 },
                new Flaps15Landing {Weight = 26000, Vapp = 122, Vref = 121, Vga = 111 },
                new Flaps15Landing {Weight = 28000, Vapp = 126, Vref = 126, Vga = 116 },
                new Flaps15Landing {Weight = 29000, Vapp = 129, Vref = 129, Vga = 119 }

                };
            foreach (Flaps15Landing ffl in flap15table)
            {
                context.Flaps15Landing.Add(ffl);
            }
            context.SaveChanges();
            /*
            var flap35table = new Flaps35Landing[]
            {
                new Flaps35Landing {Weight = 18000, Vapp = "", Vref = 101, Vga = "" },
                new Flaps35Landing {Weight = 20000, Vapp = "", Vref = 102, Vga = "" },
                new Flaps35Landing {Weight = 22000, Vapp = "", Vref = 107, Vga = "" },
                new Flaps35Landing {Weight = 24000, Vapp = "", Vref = 112, Vga = "" },
                new Flaps35Landing {Weight = 26000, Vapp = "", Vref = 116, Vga = "" },
                new Flaps35Landing {Weight = 28000, Vapp = "", Vref = 120, Vga = "" },
                new Flaps35Landing {Weight = 29000, Vapp = "", Vref = 123, Vga = "" }

            };
            foreach (Flaps35Landing f3l in flap35table)
            {
                context.Flaps35Landing.Add(f3l);
            }
            context.SaveChanges();
            */
            var flaps5takeofftable = new Flaps5Takeoff[]
            {
                //if (OAT <= 20) {
                //OAT at or below 20 degrees celsius
                new Flaps5Takeoff { Weight = 18000, Altitude = 0, Vr = 102, V2 = 116 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 0, Vr = 105, V2 = 115 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 0, Vr = 112, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 0, Vr = 118, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 0, Vr = 124, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 0, Vr = 130, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 0, Vr = 133, V2 = 135 },

                    // change of altitude 2000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 2000, Vr = 102, V2 = 115 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 2000, Vr = 106, V2 = 114 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 2000, Vr = 113, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 2000, Vr = 119, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 2000, Vr = 125, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 2000, Vr = 131, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 2000, Vr = 134, V2 = 135 },

                    //change of altitude 4000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 4000, Vr = 102, V2 = 114 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 4000, Vr = 107, V2 = 113 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 4000, Vr = 113, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 4000, Vr = 120, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 4000, Vr = 126, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 4000, Vr = 131, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 4000, Vr = 135, V2 = 135 },

                    //change of altitude 6000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 6000, Vr = 102, V2 = 113 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 6000, Vr = 107, V2 = 112 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 6000, Vr = 114, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 6000, Vr = 120, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 6000, Vr = 126, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 6000, Vr = 132, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 6000, Vr = 136, V2 = 135 },

                    //change of altitude 8000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 8000, Vr = 102, V2 = 112 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 8000, Vr = 108, V2 = 112 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 8000, Vr = 115, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 8000, Vr = 121, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 8000, Vr = 127, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 8000, Vr = 133, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 8000, Vr = 137, V2 = 135 },

                    //change of altitude 10000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 10000, Vr = 103, V2 = 111 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 10000, Vr = 110, V2 = 111 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 10000, Vr = 116, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 10000, Vr = 122, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 10000, Vr = 128, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 10000, Vr = 134, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 10000, Vr = 138, V2 = 135 },
              //  }
            //else {
                // if (OAT >= 20) {

                //OAT ABOVE 20 degrees

                new Flaps5Takeoff { Weight = 18000, Altitude = 0, Vr = 102, V2 = 114 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 0, Vr = 107, V2 = 113 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 0, Vr = 113, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 0, Vr = 120, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 0, Vr = 126, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 0, Vr = 131, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 0, Vr = 135, V2 = 135 },

                    // change of altitude 2000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 2000, Vr = 102, V2 = 113 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 2000, Vr = 108, V2 = 112 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 2000, Vr = 114, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 2000, Vr = 120, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 2000, Vr = 126, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 2000, Vr = 132, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 2000, Vr = 136, V2 = 135 },

                    //change of altitude 4000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 4000, Vr = 102, V2 = 112 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 4000, Vr = 108, V2 = 112 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 4000, Vr = 115, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 4000, Vr = 121, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 4000, Vr = 127, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 4000, Vr = 133, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 4000, Vr = 137, V2 = 135 },

                    //change of altitude 6000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 6000, Vr = 103, V2 = 111 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 6000, Vr = 110, V2 = 111 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 6000, Vr = 116, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 6000, Vr = 122, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 6000, Vr = 128, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 6000, Vr = 134, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 6000, Vr = 138, V2 = 135 },

                    //change of altitude 8000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 8000, Vr = 103, V2 = 110 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 8000, Vr = 110, V2 = 111 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 8000, Vr = 117, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 8000, Vr = 123, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 8000, Vr = 129, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 8000, Vr = 135, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 8000, Vr = 138, V2 = 135 },

                    //change of altitude 10000
                    new Flaps5Takeoff { Weight = 18000, Altitude = 10000, Vr = 105, V2 = 109 },
                    new Flaps5Takeoff { Weight = 20000, Altitude = 10000, Vr = 112, V2 = 111 },
                    new Flaps5Takeoff { Weight = 22000, Altitude = 10000, Vr = 118, V2 = 117 },
                    new Flaps5Takeoff { Weight = 24000, Altitude = 10000, Vr = 124, V2 = 122 },
                    new Flaps5Takeoff { Weight = 26000, Altitude = 10000, Vr = 130, V2 = 127 },
                    new Flaps5Takeoff { Weight = 28000, Altitude = 10000, Vr = 136, V2 = 132 },
                    new Flaps5Takeoff { Weight = 29000, Altitude = 10000, Vr = 140, V2 = 135 }
                   // }
                    
                };
            foreach (Flaps5Takeoff f5t in flaps5takeofftable)
            {
                context.Flaps5Takeoff.Add(f5t);
            }
            context.SaveChanges();
        }
    }
}