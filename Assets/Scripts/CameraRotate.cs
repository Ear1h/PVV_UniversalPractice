using UnityEngine;
public class CameraRotate : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float hOffset = 0.0f; 
    private float vOffset = 0.0f; 
    void Update()
    {
        vOffset += speedH * Input.GetAxis("Mouse X");
        hOffset -= speedV * Input.GetAxis("Mouse Y");
       
        transform.eulerAngles = new Vector3(hOffset, vOffset, 0.0f);
    }
}