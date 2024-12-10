using System.Collections;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        public void Move(Vector2 moveVector)
        {
            transform.position += (Vector3)moveVector;
        }
    }
}