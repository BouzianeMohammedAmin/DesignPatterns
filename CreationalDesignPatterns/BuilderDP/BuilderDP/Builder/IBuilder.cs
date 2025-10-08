namespace BuilderDP.Builder;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}