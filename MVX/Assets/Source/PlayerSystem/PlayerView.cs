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

        public void PlayerDeath()
        {
            gameObject.SetActive(false);
        }

        public void DrawHealth(int health)
        {
            healthText.text = "Health: " + health.ToString();

            if(health <= 25)
            {
                playerRenderer.color = playerLowHealthColor;
            }
            else if (health <= 50)
            {
                playerRenderer.color = playerLowMidHealthColor;
            }
            else if (health <= 75)
            {
                playerRenderer.color = playerUpMidHealthColor;
            }
            else if (health <= 100)
            {
                playerRenderer.color = playerMaxHealthColor;
            }
        }
    }
}