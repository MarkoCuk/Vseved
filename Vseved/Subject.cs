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
    
    public partial class Subject
    {
        public Subject()
        {
            this.Quiz = new HashSet<Quiz>();
        }
    
        public int Id { get; set; }
        public int Class_Id { get; set; }
        public string Name { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual ICollection<Quiz> Quiz { get; set; }
    }
}