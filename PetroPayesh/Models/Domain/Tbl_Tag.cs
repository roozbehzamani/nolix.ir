//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetroPayesh.Models.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Tag
    {
        public int ID { get; set; }
        public int MainProductID { get; set; }
        public string TagText { get; set; }
        public int TagProductID { get; set; }
    }
}