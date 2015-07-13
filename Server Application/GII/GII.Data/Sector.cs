//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GII.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sector
    {
        public Sector()
        {
            this.Reviews = new HashSet<Review>();
            this.Segments = new HashSet<Segment>();
        }
    
        public int SectorId { get; set; }
        public int OriginCityId { get; set; }
        public int DestinationCityId { get; set; }
        public System.DateTime PlanDate { get; set; }
        public double Cost { get; set; }
        public Nullable<double> Distance { get; set; }
        public int NoOfSegments { get; set; }
        public int UserId { get; set; }
        public bool Completed { get; set; }
    
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Segment> Segments { get; set; }
    }
}