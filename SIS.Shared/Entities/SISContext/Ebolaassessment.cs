using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Ebolaassessment
    {
        public string Studentid { get; set; }
        public string Placeofresidence { get; set; }
        public string Townofresidence { get; set; }
        public string Rescountryid { get; set; }
        public bool Livedortravelledout { get; set; }
        public string Livedortravelledoutlocation { get; set; }
        public bool Contactwithillperson { get; set; }
        public string Contactwithillpersontime { get; set; }
        public bool Contactwithbat { get; set; }
        public bool Contactwithmonkey { get; set; }
        public bool Contactwithantelope { get; set; }
        public bool Fever { get; set; }
        public bool Headache { get; set; }
        public bool Bodyache { get; set; }
        public bool Sorethroat { get; set; }
        public bool Vomiting { get; set; }
        public bool Diarrhoea { get; set; }
        public bool Reddenedeye { get; set; }
        public bool Redishpeelyrash { get; set; }
        public bool Bleeding { get; set; }
        public DateTime Datetimeupdated { get; set; }

        public virtual Student Student { get; set; }
    }
}
