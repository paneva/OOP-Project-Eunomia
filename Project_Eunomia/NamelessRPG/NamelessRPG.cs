using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace NamelessRPG
{
    public partial class NamelessRPG : Form
    {
        private Player _player;

        public NamelessRPG()
        {
            InitializeComponent();


            _player = new Player(1, "Josh", 100, 100, 0, 0, 1);

   //         IblHitPoints.Text = _player.MaximumHitPoints.ToString();
   //         IblGold.Text = _player.Gold.ToString();
   //         IblExperience.Text = _player.ExperiencePoints.ToString();
   //         IblLevel.Text = _player.Level.ToString();


        }
    }
}
