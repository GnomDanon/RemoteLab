
namespace DB.Entities
{
    public class Equipment
    {
        public int Id { get; private set; }
        public HardwarePlatform? HardwarePlatform { get; set; }
        public HardwareFeature? HardwareFeature { get; set; }
    }
}
