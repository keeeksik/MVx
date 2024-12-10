using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInput : MonoBehaviour
    {
        public event Action<Vector2> OnPlayerMove;

        private void Update()
        {
            OnPlayerMove?.Invoke(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
        }
    }
}
