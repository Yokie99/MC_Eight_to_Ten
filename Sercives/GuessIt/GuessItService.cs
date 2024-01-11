
namespace MC_Eight_to_Ten.Sercives.GuessIt
{
    public class GuessItService : IGuessItService
    {
        public string easy(string input)
        {
            var rand = new Random();
            double target = rand.Next(1, 11);
            bool isNum = double.TryParse(input, out double num);

            if (isNum){
                if(num > target){
                    return $"Your guess, {input}, is more than the secret number! The secret number was {target}";
                }
                else if(num < target){
                    return $"Your guess, {input}, is less than the secret number! The secret number was {target}";
                }
                else{
                    return $"Your guess, {input}, is the same as the secret number, {target}! CONGRATS. ";
                }
            }
            else{
                return $"Your input: {input}, is not a valid number! Try again.";
            }
        }

        public string medium(string input)
        {
var rand = new Random();
            double target = rand.Next(1, 51);
            bool isNum = double.TryParse(input, out double num);

            if (isNum){
                if(num > target){
                    return $"Your guess, {input}, is more than the secret number! The secret number was {target}";
                }
                else if(num < target){
                    return $"Your guess, {input}, is less than the secret number! The secret number was {target}";
                }
                else{
                    return $"Your guess, {input}, is the same as the secret number, {target}! CONGRATS. ";
                }
            }
             else{
                return $"Your input: {input}, is not a valid number! Try again.";
            }
        }

        public string hard(string input)
        {
var rand = new Random();
            double target = rand.Next(1, 101);
            bool isNum = double.TryParse(input, out double num);

            if (isNum){
                if(num > target){
                    return $"Your guess, {input}, is more than the secret number! The secret number was {target}";
                }
                else if(num < target){
                    return $"Your guess, {input}, is less than the secret number! The secret number was {target}";
                }
                else{
                    return $"Your guess, {input}, is the same as the secret number, {target}! CONGRATS. ";
                }
            }
             else{
                return $"Your input: {input}, is not a valid number! Try again.";
            }
        }
    }
}