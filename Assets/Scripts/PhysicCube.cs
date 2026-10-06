using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicCube : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddTorque(Vector3.up * speed * Time.deltaTime, ForceMode.VelocityChange);
    }

}