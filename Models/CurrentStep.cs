
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EntityModels
{

using System;
    using System.Collections.Generic;
    
public partial class CurrentStep
{

    public int Id { get; set; }

    public int StepId { get; set; }

    public int UserId { get; set; }

    public int DocumentId { get; set; }



    public virtual Document Document { get; set; }

    public virtual Step Step { get; set; }

    public virtual User User { get; set; }

}

}
