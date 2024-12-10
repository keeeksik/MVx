using System.Collections;
using TMPro;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Color playerLowHealthColor;
        [SerializeField] private Color playerLowMidHealthColor;
        [SerializeField] private Color playerUpMidHealthColor;
        [SerializeField] private Color playerMaxHealthColor;
        [SerializeField] private SpriteRenderer playerRenderer;
        [SerializeField] private TMP_Text healthText;
        private PlayerModel playerModel;

        public void Initialize(PlayerModel playerModel)
        {
            this.playerModel = playerModel;
            playerModel.OnHealthChanged += DrawHealth;
            playerModel.OnPlayerDeath += PlayerDeath;
        }

        public void PlayerDeath()
        {
            gameObject.SetActive(false);
        }

        public void DrawHealth()
        {
            healthText.text = "Health: " + playerModel.GetHealth();

            if(playerModel.GetHealth() <= 25)
            {
                playerRenderer.color = playerLowHealthColor;
            }
            else if (playerModel.GetHealth() <= 50)
            {
                playerRenderer.color = playerLowMidHealthColor;
            }
            else if (playerModel.GetHealth() <= 75)
            {
                playerRenderer.color = playerUpMidHealthColor;
            }
            else if (playerModel.GetHealth() <= 100)
            {
                playerRenderer.color = playerMaxHealthColor;
            }
        }
    }
}