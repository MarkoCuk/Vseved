//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vseved
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkTask
    {
        public int Id { get; set; }
        public int Quiz_Id { get; set; }
        public string Description { get; set; }
        public int TotalPoints { get; set; }
        public bool ImageType { get; set; }
        public string CorrectAnswer { get; set; }
        public string Options { get; set; }
    
        public virtual Quiz Quiz { get; set; }
    }
}