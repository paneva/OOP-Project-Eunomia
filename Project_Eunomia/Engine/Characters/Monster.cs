using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Characters
{
    public class Monster : LivingCreature
    {
        
        public bool IsKills;

        public Monster(int id, string name, bool isKills) 
            : base (id, name)
        {
            ID = id;
            Name = name;
            IsKills = isKills;
        }
    }
}
