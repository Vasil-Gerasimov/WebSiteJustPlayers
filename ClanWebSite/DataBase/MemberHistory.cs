//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberHistory
    {
        public long Date { get; set; }
        public string Tag { get; set; }
        public int ClanMember { get; set; }
        public int ClanChestCrowns { get; set; }
        public int Donations { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
