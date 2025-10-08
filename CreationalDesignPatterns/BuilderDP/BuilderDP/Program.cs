
//Using Builder Design Pattern to create a complex object step by step.

using BuilderDP;
using BuilderDP.Builder;

//IBuilder builder = new SimpleProductBuilder(); 
IBuilder builder = new ComplexProductBuilder(); 

//we can do not  utilise the director
//ProductDirector director = new ProductDirector(builder);

//director.ConstructProduct();
builder.BuildName();
builder.BuildDescription();
Product product = builder.Build();
Console.WriteLine(product); 
 