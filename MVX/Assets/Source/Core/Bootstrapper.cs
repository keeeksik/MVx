using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerView playerViewPrefab;
        private PlayerMovementModel playerMovementModel;
        private PlayerMovement playerMovement;
        private PlayerInput playerInput;
        private PlayerModel playerModel;
        private PlayerMovementController playerMovementController;
        private DamageListener damageListener;

        private void Awake()
        {
            PlayerView playerView = Instantiate(playerViewPrefab);
            playerMovement = playerView.GetComponent<PlayerMovement>();
            playerInput = playerView.GetComponent<PlayerInput>();
            playerMovementModel = playerView.GetComponent<PlayerMovementModel>();
            damageListener = playerView.GetComponent<DamageListener>();
            playerModel = new PlayerModel();
            damageListener.Initialize(playerModel);
            playerView.Initialize(playerModel);

            playerMovementController = new PlayerMovementController(playerMovementModel, playerMovement, playerInput);
        }
    }
}