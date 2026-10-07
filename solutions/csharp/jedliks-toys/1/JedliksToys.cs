class RemoteControlCar
{
    private int metersDriven=0;
    private int batteryPercentage=100;
    
    public static RemoteControlCar Buy()
    {
       RemoteControlCar newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryPercentage!=0)
            return $"Battery at {batteryPercentage}%";
        else   
            return "Battery empty";
    }

    public void Drive()
    {
        if(batteryPercentage!=0)
        {
        metersDriven += 20;
        batteryPercentage-=1;
        }
    }
}
