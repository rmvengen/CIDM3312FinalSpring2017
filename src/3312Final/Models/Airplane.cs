using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _3312Final.Models
{


    public class AirplaneViewModel
    {
        public Airplane Q400 { get; set; }
        public List<Airplane> Q400s { get; set; }
    }

    public class Airplane
    {
        
        public string ID { get; set; }
        [Range(18000, 29000)]
        public int Weight { get; set; }
        [Range(0, 10000)]
        public int Altitude { get; set; }
        [Range(0, 359)]
        public int RunwayDirection { get; set; }
        public int FlapSetting { get; set; }
        public bool Ice { get; set; }
        public bool Rain { get; set; }
        public bool Snow { get; set; }
        [Range(0,359)]
        public double WindDirection { get; set; }
        [Range(0,50)]
        public int WindSpeed { get; set; }
        [Range(0,1114)]
        public int TripDistance { get; set; }
        public bool Headwind { get; set; }
        public double DirectionalWind { get; set; }
        public string Pilot { get; set; }
        public int FlapSettingLand { get; set; }
        [Range(-30, 50)]
        public int OutsideAirTemp { get; set; }

        public Airplane()
        {

        }
        public Airplane(string id, int weight, int altitude, int runwayDirection,
                        int flapsetting, bool ice, bool rain, bool snow,
                        int windDirection, int windSpeed, int tripDistance, 
                        int flapsettingland, bool headwind, double directionalwind,
                        string pilot, int outsideairtemp)
        {
            this.ID = id;
            this.Weight = weight;
            this.Altitude = altitude;
            this.RunwayDirection = runwayDirection;
            this.FlapSetting = flapsetting;
            this.FlapSettingLand = flapsettingland;
            this.Ice = ice;
            this.Rain = rain;
            this.Snow = snow;
            this.WindDirection = windDirection;
            this.WindSpeed = windSpeed;
            this.TripDistance = tripDistance;
            this.Headwind = headwind;
            this.DirectionalWind = directionalwind;
            this.Pilot = pilot;
            this.OutsideAirTemp = outsideairtemp;

        }

    }
}
