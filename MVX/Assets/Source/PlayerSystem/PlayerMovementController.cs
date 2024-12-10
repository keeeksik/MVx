using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovementController
    {
        private PlayerMovementModel model;
        private PlayerMovement movement;
        private PlayerInput input;

        public PlayerMovementController(PlayerMovementModel moveModel, PlayerMovement playerMovement, PlayerInput playerInput)
        {
            model = moveModel;
            movement = playerMovement;
            input = playerInput;
            input.OnPlayerMove += MovePlayer;
        }

        private void MovePlayer(Vector2 moveVector)
        {
            movement.Move(moveVector * model.GetPlayerSpeed() * Time.deltaTime);
        }
    }
}
