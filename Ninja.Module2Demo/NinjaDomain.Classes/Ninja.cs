﻿using System;
using System.Collections.Generic;

namespace NinjaDomain.Classes
{
    public class Ninja : Interfaces.IModificationHistory
    {
        public Ninja()
        {
            EquipmentOwned = new List<NinjaEquipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public virtual List<NinjaEquipment> EquipmentOwned { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public DateTime DateModified { get; set ; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}
