﻿using Core.Persistence.Repositories;


namespace Domain.Entities.Items;

public class ItemSet : Entity<string>
{
    public string SetType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public string Rarity { get; set; }
    public int Cost { get; set; }
    public int Resell { get; set; }
    public List<UniqueItem> UniqueItems { get; set; }
    public List<SetBonus> SetBonuses { get; set; }
}