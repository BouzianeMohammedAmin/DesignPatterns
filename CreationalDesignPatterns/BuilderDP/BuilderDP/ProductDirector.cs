using BuilderDP.Builder;

namespace BuilderDP;

public class ProductDirector(IBuilder builder)
{
    public void ConstructProduct()
    {
        builder.BuildName();
        builder.BuildDescription();
    }
}