//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerHosting
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public long CnicNo { get; set; }
        public Nullable<int> CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
        public double Percentage { get; set; }
    
        public virtual StudentInformation StudentInformation { get; set; }
    }
}
