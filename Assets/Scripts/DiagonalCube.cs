using UnityEngine;
public class DiagonalCube : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 5f;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

 
    private void FixedUpdate()
    {
     if (Input.GetKey(KeyCode.T))
        {
          
            Vector3 movement = new Vector3(speed, 0, speed);

            rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
        }
    }
}