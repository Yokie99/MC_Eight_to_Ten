


namespace MC_Eight_to_Ten.Sercives.EightBall
{
    public class EightBallService : IEightBallService
    {
        public string magic()
        {
            var rand = new Random();
            string[] results = {"Yes", "No", "Maybe", "100%", "signs point to yes", "signs point to no", "Probably not", "I cant predict right now"};
            return results[rand.Next(7)];
        }
    }
}