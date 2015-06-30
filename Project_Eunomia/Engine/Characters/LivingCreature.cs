using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Characters
{
    public class LivingCreature
    {
        public int id;
        public string name;

        public LivingCreature(int id, string name)
        {
            Name = name;
            ID = id;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
