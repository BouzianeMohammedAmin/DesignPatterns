
//Using Builder Design Pattern to create a complex object step by step.

using BuilderDP;
using BuilderDP.Builder;

//IBuilder builder = new SimpleProductBuilder(); 
IBuilder builder = new ComplexProductBuilder(); 


ProductDirector director = new ProductDirector(builder);

director.ConstructProduct();

Product product = builder.Build();
Console.WriteLine(product);
 