class Car
{
    // declaring private variables and getters and setters
    public string UserColor {get; set;}
    public string UserModel {get; set;}
    
    // class constructor
    public Car()
    {
        UserColor = "undefined";
        UserModel = "undefined";
    }

    // for user to pass information
    public Car(string userModel, string userColor)
    {
        this.UserColor = userColor;
        this.UserModel = userModel;
    }

    public override string ToString()
    {
        return ("Car color: " + this.UserColor + " Car Model: " + this.UserModel);
    }


}

// variables inside of a class are called fields, we access these by using the dot syntax