using UnityEngine;

public class MoveLight: MonoBehaviour
{
    public float speed = 5.0f;

    private void Update()
    {
        float HorMove = Input.GetAxis("Horizontal");
        float VerMove = Input.GetAxis("Vertical");

        if (HorMove > 0 || VerMove < 0)
        {
            transform.Translate(Vector3.forward * VerMove * speed * Time.deltaTime);
        }
    }
}