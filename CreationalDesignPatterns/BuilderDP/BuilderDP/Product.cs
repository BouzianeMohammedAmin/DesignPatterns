namespace BuilderDP;

public record Product(string Name, string Description)
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

      public Product Build()
      {
          return  new Product(_name, _description);
      }
  }
}