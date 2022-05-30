using System;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();
            _player = new Player();
            SetNewPlayer(_player);
            RefreshScreen();
        }

        private void SetNewPlayer(Player p)
        {
            p.CurrentHitPoints = 10;
            p.MaximumHitPoints = 10;
            p.Gold = 0;
            p.ExperiencePoints = 0;
            p.Level = 1;
        }

        private void RefreshScreen()
        {
            labelHitPoints.Text = Convert.ToString(_player.CurrentHitPoints);
            labelGold.Text = Convert.ToString(_player.Gold);
            labelExperience.Text = Convert.ToString(_player.ExperiencePoints);
            labelLevel.Text = Convert.ToString(_player.Level);
        }
    }
}