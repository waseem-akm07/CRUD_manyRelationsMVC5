//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthorDetail
    {
        public int DetailId { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Address { get; set; }
        public int DetailAuthorId { get; set; }
    
        public virtual Author Author { get; set; }
    }
}
