//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int Suid { get; set; }
        public string Suname { get; set; }
        public int Course_cid { get; set; }
        public int SchoolScid { get; set; }
    
        public virtual Course Course { get; set; }
    }
}