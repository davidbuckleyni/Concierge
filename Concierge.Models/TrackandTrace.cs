using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
   public  class TrackandTrace
    {


        public int? Id { get; set; }
        public Person? PersonToTrace { get; set; }

        public DateOnly? DateVisted { get; set; }

        public  bool? MaskWorn { get; set; }

        public bool? DetailsRecorded { get; set; }

        public bool? HasPersonBeenAlearted { get; set; }


        public bool? HasNHSTrackAndTraceBeenAlearted { get; set; }
    }
}
