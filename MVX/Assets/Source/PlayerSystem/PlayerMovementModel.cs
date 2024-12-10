using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovementModel : MonoBehaviour
    {
        [SerializeField] private int playerSpeed;

        public int GetPlayerSpeed()
        {
            return playerSpeed;
        }
    }
}
