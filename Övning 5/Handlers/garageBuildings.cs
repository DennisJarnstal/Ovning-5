namespace Övning_5
{
    public class garageBuildings : EntityBase
    {
        public string Name { get; set; }

        public override string ToString() => $"Id; {Id}, Namn på garage: {Name}";
    }

}
