using Microsoft.AspNetCore.Mvc;

namespace Add_2_Numbers___Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers : ControllerBase
    {
        public List<string> numbersHold = new();

        [HttpPost]
        [Route("addNumbers/{num1}/{num2}")]
        public List<string> AddNumbers(string num1, string num2)
        {
            int convertNum1;
            int convertNum2;

            bool isValied = int.TryParse(num1, out convertNum1);
            bool isValied1 = int.TryParse(num2, out convertNum2);

            if (isValied == false && isValied1 == false){
                numbersHold.Add("Both numbers are not numbers");
            }else if(isValied == false){
                numbersHold.Add("The first number is not a number");
            }else if(isValied1 == false){
                numbersHold.Add("The second number is not a number");
            }else if (isValied == true && isValied1 == true){
                int sum = convertNum1 + convertNum2;
                numbersHold.Add(sum.ToString());
            }else{
                numbersHold.Add("An error occured");
            }

            return numbersHold;
        }
    }
}
