using UnityEngine;

public class Cylinder: MonoBehaviour
{
    public GameObject CylinderDelete;

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Instantiate(CylinderDelete, new Vector3(0, 0, 0), Quaternion.identity);
    }
}