using System;

namespace API_POC.Models
{
    public class Catalogue
    {
      public Guid CatalogueId { get; set; }
      public string CreatedBy { get; set; }
      public DateTime Created {get;set;}
      public string UpdatedBy {get;set;}
      public DateTime Updated {get;set;}
      public string Name {get;set;}
      public string Description {get;set;}
      public Guid WorkflowId {get;set;}
      public Guid CategoryId {get;set;}
      public Guid ImageId {get;set;}
      public int Order {get;set;}
      public bool IsActive {get;set;}
      public bool HasUI {get;set;}
    }
}
