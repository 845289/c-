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
    
    public partial class Student
    {
        public int Stid { get; set; }
        public string Stname { get; set; }
        public int Course_cid { get; set; }
        public int Exam_eid { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
