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
    
    public partial class Place
    {
        public Place()
        {
            this.Photos = new HashSet<Photo>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int PlaceId { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public Nullable<double> XCoordinate { get; set; }
        public Nullable<double> YCoordinate { get; set; }
    
        public virtual City City { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}