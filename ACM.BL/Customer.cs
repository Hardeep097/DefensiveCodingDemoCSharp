using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Customer
    {

        public int CustomerId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.Email))
            {
                op.Success = false;
                op.MessageList.Add("Email adress is null");
            }
            var isValidFormat = true;
            //code here to check valid email
            //using rgex
            if (op.Success)
            {
                 if (!isValidFormat)
                    {
                    op.Success = false;
                    op.MessageList.Add("Email adress is not in correct format");
                    }
            }
           
            var isRealDomain = true;
            //code here that could check whether domain exist
            if (op.Success)
            {
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.MessageList.Add("Email adress does not include a valid domain");
                }
   
            }
            return op;
        }

        public decimal calculatePercentOfGoalSteps(string goalStep, string actualSteps)
        {
            
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalStep)) throw new ArgumentException("Goal must be entered", "goalStep");
            if (string.IsNullOrWhiteSpace(goalStep)) throw new ArgumentException("Actual step count must be entered", "actualStep");


           if( !decimal.TryParse(goalStep, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if(!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric","actualStep");


            
            return calculatePercentOfGoalSteps(goalStepCount, actualStepCount);
            
        }

        public decimal calculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalStep");
            return Math.Round((actualStepCount / goalStepCount),2) * 100;
        }

    }
}
