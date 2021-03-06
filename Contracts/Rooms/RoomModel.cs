using Common;
using Common.Extensions;

namespace Contracts.Rooms
{
    public class RoomModel : IEntity
    {
        public RoomModel()
        {
            
        }
        public RoomModel(int id)
        {
            Id = id;
        }

        public RoomModel(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return this.ToDebugString(nameof(Id), nameof(Location));
        }
    }
}