/*
* Todays work will be refactoring the Car, Door and Tire class into seperate files
* and laying the ground work for the next assignment
*/

//Instantiating a Car class / Creating an object of type Car
Car car1 = new Car("BMW");
Car car2 = new Car("Toyota", 2, 8, 25);

Console.ReadKey();

//Class definition
    #region Methods
    
    void Break(){
        _speed = 0f;
    }

    public void Accelerate(float forceParameter){
        _speed = _speed + forceParameter;
    }
    
    public int ChangeGear(int amount){
        CurrentGear += amount;
        return CurrentGear;
    }

    private void GetIn(Door doorParameter){
        doorParameter.Open();
        Console.WriteLine("Got inside " + Brand);
        doorParameter.Close();
    }

    #endregion
}


