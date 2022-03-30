using System;

public class ParkingPlace
{
    public int[] SimulateDay(int hourPrice, int feeSize, int VP, int clients)
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        int TotalCharge = 0;

        int[] CIV = new int[4];
        for (int i = 0; i < 4; i++) CIV[i] = 0;

        int hours = 24;

        for (int i = 0; (i < clients) && (hours > 0); i++)
        {
            if (random.Next(100)+1 > i*15) { // Client rough intersection chance
                //Add 24 hours validation
                int clientHours = (random.Next(12) + 1);
                if (random.Next(100) + 1 > VP)
                {
                    if (clientHours > hours) clientHours = hours;
                    TotalCharge += clientHours * hourPrice;
                    hours -= clientHours;
                }
                else
                {
                    if (clientHours > hours) clientHours = 1;
                    int expHours = (random.Next(6) + 1);
                    TotalCharge += clientHours * hourPrice + feeSize * expHours;
                    hours -= (clientHours + expHours);
                    CIV[2]++;
                    CIV[3] += feeSize * expHours;
                }
            }
            else
            {
                CIV[1]++;
            }
        }
        CIV[0] = TotalCharge;
        return CIV;
    }

}
