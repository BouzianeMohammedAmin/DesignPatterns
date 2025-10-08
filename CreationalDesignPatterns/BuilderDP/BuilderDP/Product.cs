namespace BuilderDP;

public record Product(string Name, string Description , Owner owner)
{
    //Nested Builder 
  /*  public  class Builder  
        {
            private string _name = "";
            private string _description = "";
        
            public void BuildName( string name )
            {
                _name = name;
            }

            public void BuildDescription(string description)
            {
                _description = description;
            }

            public Product Build()
            {
                return  new Product(_name, _description);
            }
        }
    */
  
  //Fluent Builder
  public  class Builder  
  {
      private string _name = "";
      private string _description = "";
      private Owner _owner = null!;
    
      public Builder SetName( string name )
      {
          _name = name;
          return this;
      }

      public Builder SetDescription(string description)
      {
          _description = description;
          return this;
      }
      public Builder SetOwner(Action<Owner.Builder> action)
      {
          
          var ownerBuilder = new Owner.Builder();
            action(ownerBuilder);
          _owner = ownerBuilder.Build();
          return this;
      }
      

      public Product Build()
      {
          return  new Product(_name, _description , _owner);
      }
  }
}