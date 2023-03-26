namespace Inheritance
{
    class Company
    {
        public string Name { get; set; }
    }

    class Department 
    {
    }

    class MarketingDepartment : Department
    {
    }

    class EmailCampaignsDepartment: MarketingDepartment
    {
    }

    public class IsA2
    {
        public static void Main()
        { }
    }
}