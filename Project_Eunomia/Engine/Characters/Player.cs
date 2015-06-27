using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }


        public Player(int id, string name, int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) 
            : base( id,  name)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
