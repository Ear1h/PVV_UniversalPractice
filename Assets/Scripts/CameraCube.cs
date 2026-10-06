using UnityEngine;

public class CameraCube: MonoBehaviour
{
    [SerializeField] GameObject CameraObject;

    public float OffSetZ = 6f, OffsetY = 3f;
    private Vector3 offset;

    private void Start()
    {
        offset = new Vector3(CameraObject.transform.position.x, CameraObject.transform.position.y + OffsetY, CameraObject.transform.position.z - OffSetZ);

        transform.position = offset;
    }

    private void LateUpdate()
    {
        offset = new Vector3(CameraObject.transform.position.x, CameraObject.transform.position.y + OffsetY, CameraObject.transform.position.z - OffSetZ);
        transform.position = offset;
    }

}
