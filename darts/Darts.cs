using System;
public static class Darts
{
    public static int Score(double x, double y)
    {
        int score = 0;

        if(Math.Pow(x - 0,2) + Math.Pow(y - 0,2) <= 10 * 10)score = 1;
        else if (Math.Pow(x - 0,2) + Math.Pow(y - 0,2) <= 5 * 5) score = 5;
        else if(Math.Pow(x - 0,2) + Math.Pow(y - 0,2) <= 1) score = 10;

       return score;
    }
}
