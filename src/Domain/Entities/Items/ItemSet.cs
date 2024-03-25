

namespace Domain.Entities.Items;

public class ItemSet
{
    public Dictionary<string, Item> Items { get; set; }
    public Dictionary<string, SetBonus> SetBonuses { get; set; }
}