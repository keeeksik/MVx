using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerController
    {
        private PlayerView playerView;
        private PlayerModel playerModel;
        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            this.playerModel = playerModel;
            this.playerView = playerView;
            playerModel.OnHealthChanged += DrawHealth;
            playerModel.OnPlayerDeath += OnPlayerDeath;
        }
        private void DrawHealth()
        {
            playerView.DrawHealth(playerModel.GetHealth());
        }

        private void OnPlayerDeath()
        {
            playerView.PlayerDeath();
        }
    }
}