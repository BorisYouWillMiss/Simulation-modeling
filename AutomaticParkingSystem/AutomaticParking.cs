using System;

public class AutomaticParking
{
    public ParkingPlace[] places;
    public int workers;
    public int rent;
    private int freePlaces;
    
    public void Expand(int times)
    {
        places = new ParkingPlace[places.Length + 5 * times]; // Расширится 
        for (int i = 0; i < places.Length; i++)
            places[i] = new ParkingPlace();
        freePlaces += times;
        rent = (15000 * places.Length);
    }

    public void WorkerHire()
    {
        workers++;
        freePlaces--;
    }

    public void WorkerLeft()
    {
        workers--;
        freePlaces++;
    }

    public AutomaticParking()
    {
        places = new ParkingPlace[4]; // Minimum size
        for (int i = 0; i < places.Length; i++)
            places[i] = new ParkingPlace();
        workers = 2; // Minimum Workers, 5/1 + 1
        rent = 10000 * places.Length;
        freePlaces = 0;
    }

    public int GetFreeWorkerPlaces()
    {
        return freePlaces;
    }
}