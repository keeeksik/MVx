using PlayerSystem;
using System.Collections;
using UnityEngine;

namespace PlayerSystem
{
    public class DamageListener : MonoBehaviour
    {
        private PlayerModel _playerModel;

        public void Initialize(PlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Damage")
            {
                _playerModel.DecreaseHealth(25);
            }
        }
    }
}