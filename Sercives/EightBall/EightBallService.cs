


namespace MC_Eight_to_Ten.Sercives.EightBall
{
    public class EightBallService : IEightBallService
    {
        public string magic()
        {
            var rand = new Random();
            string[] results = {"res1", "res2", "res3", "res4", "res5", "res6", "res7", "res8"};
            return results[rand.Next(7)];
        }
    }
}