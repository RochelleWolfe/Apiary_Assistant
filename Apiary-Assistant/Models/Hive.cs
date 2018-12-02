using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apiary_Assistant.Models
{ //The Same class can be used for original start hives and hives after inspection
    public class Hive
    {
        public string HiveId { get; set; }
        public DateTime CreationDate { get; set; }
        public string OriginLocation { get; set; }
        public string OriginType { get; set; }
        public string StartQueen { get; set; }
        public string QueenAge { get; set; }

        public string HouseType { get; set; }
        public double TotalDeepFrames { get; set; }
        public double TotalMedFrames { get; set; }
        public double TotalShortFrames { get; set; }
        public double DrawnDeeps { get; set; }
        public double DrawnMeds { get; set; }
        public double DrawnShort { get; set; }
        public double DeepBrood { get; set; }
        public double MedBrood { get; set; }
        public double ShortBrood { get; set; }
        public bool IsThereHoney { get; set; }
        public bool IsThereFeed { get; set; }
        public string FoodType { get; set; }
        public double LbsOfFood { get; set; }

        public string HiveAddress { get; set; }
        public string HivePosition { get; set; }
        public string PropertyOwner { get; set; }
        public string SecondPropOwner { get; set; }

        public string HivePhoto { get; set; }




    }
}
