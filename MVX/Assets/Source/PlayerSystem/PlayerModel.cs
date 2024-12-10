using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerSystem
{
    public class PlayerModel
    {
        private int health;
        private int maxHealth = 100;
        
        public event Action OnHealthChanged;
        public event Action OnPlayerDeath;

        public PlayerModel()
        {
            health = maxHealth;
        }

        public int GetHealth()
        {
            return health;
        }

        public void DecreaseHealth(int healthToRemove)
        {
            health = Math.Clamp(health - healthToRemove, 0, maxHealth);
            OnHealthChanged?.Invoke();

            if (health == 0)
            {
                OnPlayerDeath?.Invoke();
            }
        }

        public void IncreaseHealth(int healthToAdd)
        {
            health = Math.Clamp(health + healthToAdd, 0, maxHealth);
            OnHealthChanged?.Invoke();
        }
    }
}