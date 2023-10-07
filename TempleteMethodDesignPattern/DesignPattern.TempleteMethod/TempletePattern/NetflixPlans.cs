namespace DesignPattern.TempleteMethod.TempletePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resolation(string.Empty);
            Content(string.Empty);
        }

        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countperson);
        public abstract double Price(double price);
        public abstract string Resolation(string resolation);
        public abstract string Content(string content);

    }
}
