//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int commentsId { get; set; }
        public int userId { get; set; }
        public string content { get; set; }
        public Nullable<int> levelComment { get; set; }
    
        public virtual UserStory UserStory { get; set; }
    }
}
