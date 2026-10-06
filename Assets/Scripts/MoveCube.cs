using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
public class MoveCube: Jumper
{
    public float speed = 3.0f;
    private void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal * speed, 0.0f, MoveVertical * speed);
        rb.linearVelocity = movement;
    }
}
