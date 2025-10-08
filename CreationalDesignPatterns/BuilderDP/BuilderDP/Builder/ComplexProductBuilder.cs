namespace BuilderDP.Builder;

public class ComplexProductBuilder : IBuilder
{
    private string _name = "";
    private string _description = "";
    
    public void BuildName()
    {
       _name = "Complex Product";
    }

    public void BuildDescription()
    {
        _description="This is a Complex product";
    }

    public Product Build()
    {
      return  new Product(_name, _description);
    }
}