namespace BuilderDP.Builder;

public class SimpleProductBuilder : IBuilder
{
    private string _name = "";
    private string _description = "";
    
    public void BuildName()
    {
       _name = "Simple Product";
    }

    public void BuildDescription()
    {
        _description="This is a simple product";
    }

    public Product Build()
    {
      //return  new Product(_name, _description);
      return null; 
    }
}