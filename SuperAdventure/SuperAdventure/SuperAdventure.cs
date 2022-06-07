using System;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private HealingPotion _basicHealingPotion;
        private Item _houseKey;
        private Location _playerHouse;
        public SuperAdventure()
        {
            InitializeComponent();
            Initializers();
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            lblHitPoints.Text = Convert.ToString(_player.CurrentHitPoints);
            lblGold.Text = Convert.ToString(_player.Gold);
            lblExperience.Text = Convert.ToString(_player.ExperiencePoints);
            lblLevel.Text = Convert.ToString(World.ItemByID(World.ITEM_ID_CLUB).Name);
        }

        private void Initializers()
        {
            _player = new Player(10, 10, 20, 0, 1);
            _basicHealingPotion = new HealingPotion(1, "Basic Healing Potion", "Basic Healing Potions", 10);
            _houseKey = new Item(2, "House Key", "House Keys");
            _playerHouse = new Location(1, "Home", "Safe place where the player can rest and recover after an adventure",
                _houseKey);
        }
    }
}

// 11.1 Using a static class