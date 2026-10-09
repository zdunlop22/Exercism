class RemoteControlCar
{
    int speed;
    int batteryDrain;
    int distanceDriven=0;
    int batteryPercentage=100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => (batteryPercentage<batteryDrain);
    

    public int DistanceDriven() => distanceDriven;
   

    public void Drive()
    {
        if (!BatteryDrained())
        {
            batteryPercentage -= batteryDrain;
            distanceDriven += speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4); 
    
}

class RaceTrack
{
    int distance;
    public RaceTrack(int trackDistance)
    {
        distance = trackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
            car.Drive();
        return (car.DistanceDriven()>=distance);
    }
}
