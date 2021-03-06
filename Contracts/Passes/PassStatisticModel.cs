using Common;

namespace Contracts.Passes
{
    public class PassStatisticModel : IEntity
    {
        public PassModel Pass { get; set; }
        public decimal CostPerClass { get; set; }
        public int NumberOfClassesAttended { get; set; }
        public int Id { get; set; }
    }
}