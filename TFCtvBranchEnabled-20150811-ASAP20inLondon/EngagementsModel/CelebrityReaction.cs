//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace EngagementsModel
{
    public partial class CelebrityReaction
    {
        public int Reactionid { get; set; }
        public int ReactionTypeId { get; set; }
        public int CelebrityId { get; set; }
        public System.Guid UserId { get; set; }
        public System.DateTime DateTime { get; set; }
    }
    
}
