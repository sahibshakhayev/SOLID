// Bad Example
public class SATA_HDD
{

    public int rpm;
    public double write_speed;
    public double read_speed;

}

public class SATA_SSD
{
    public double write_speed;
    public double read_speed;
    public int life_res;

}
public class GetStorageSpeed
{

    public string CALCULATE_SATA_HDD_SPEED(SATA_HDD hdd)
    {

        return hdd.write_speed + " " + hdd.read_speed;

    }

    public string CALCULATE_SATA_SSD_SPEED(SATA_SSD ssd)
    {

        return ssd.write_speed + " " + ssd.read_speed;

    }

}

// Good Example
public interface Speed
{

    public string CalculateSpeed();

}

// SATA HDD Speed
public class SATA_HDD_Drive : Speed {


    public int rpm;
    public double write_speed;


    public double read_speed;


    public string CalculateSpeed()
    {
        return this.write_speed + " " + this.read_speed;
    }
}


public class SATA_SSD_Drive : Speed
{


    public int rpm;
    public double write_speed;


    public double read_speed;


    public string CalculateSpeed()
    {
        return this.write_speed + " " + this.read_speed;
    }
}




