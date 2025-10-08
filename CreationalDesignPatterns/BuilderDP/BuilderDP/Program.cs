
//Using Builder Design Pattern to create a complex object step by step.

using BuilderDP;
using BuilderDP.Builder;

//IBuilder builder = new SimpleProductBuilder(); 
//IBuilder builder = new ComplexProductBuilder(); 

//we can do not  utilise the director
//ProductDirector director = new ProductDirector(builder);

//director.ConstructProduct();
//nested Builder  
Product.Builder builder = new Product.Builder(); 
builder.BuildName("macobook pro 2018 ");
builder.BuildDescription("this  is a  macbook pro 2018 with 16gb ram and 512gb ssd ");

Product product = builder.Build();
Console.WriteLine(product); 
 