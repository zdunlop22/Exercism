class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesPassed)
    {
        int totalMinutes = ExpectedMinutesInOven();
        return totalMinutes - minutesPassed;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int prepTime = layers * 2;
        return prepTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesPassed)
    {
        return PreparationTimeInMinutes(layers) + minutesPassed;
    }
}
