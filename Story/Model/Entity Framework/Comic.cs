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
    
    public partial class Comic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comic()
        {
            this.BookMarks = new HashSet<BookMark>();
            this.ChapterDirectories = new HashSet<ChapterDirectory>();
            this.AuthorsDetails = new HashSet<AuthorsDetail>();
            this.CategoriesDetails = new HashSet<CategoriesDetail>();
        }
    
        public int comicId { get; set; }
        public string title { get; set; }
        public string imageTitle { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> dateSubmitted { get; set; }
        public Nullable<int> statusId { get; set; }
        public Nullable<long> viewers { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookMark> BookMarks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChapterDirectory> ChapterDirectories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuthorsDetail> AuthorsDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriesDetail> CategoriesDetails { get; set; }
        public virtual StatusStory StatusStory { get; set; }
    }
}
