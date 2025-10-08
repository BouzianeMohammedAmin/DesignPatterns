namespace BuilderDP;

public record Owner(string Name , String email)
{

    public  class Builder  
    {
        private string _name = string.Empty;
        private string _email =string.Empty;
    
        public Builder SetName( string name )
        {
            _name = name;
            return this;
        }

        public Builder SetEmail(string email)
        {
            _email = email;
            return this;
        }

        public Owner Build()
        {
            return  new Owner(_name, _email);
        }
    }
    
}