using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Characters
{
    class LifeMonster : Monster
    {
        public const bool isKills=true;
        public LifeMonster(int id, string name)
            :base(  id,  name,  isKills)
        {
        }
    }
}