namespace DesignPattern.TempleteMethod.TempletePattern
{
    public class BasicPlan : NetflixPlans
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countperson)
        {
            return countperson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resolation(string resolation)
        {
            return resolation;
        }
    }
}
