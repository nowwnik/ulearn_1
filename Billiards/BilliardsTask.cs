namespace Billiards;

public static class BilliardsTask
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="directionRadians">Угол направления движения шара</param>
    /// <param name="wallInclinationRadians">Угол</param>
    /// <returns></returns>
    public static double BounceWall(double directionRadians, double wallInclinationRadians)
    {
        wallInclinationRadians += 90;
        directionRadians += 180;

        double delta = wallInclinationRadians - directionRadians;
        double res = directionRadians + 2 * delta + 360 * 5;

        res %= 360;

        if (res > 180) return res -= 360;
        return res;
    }
}