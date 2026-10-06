using UnityEngine;

public class InvokeFunc: MonoBehaviour
{

    private void OnMouseUp()
    {
        Invoke("DestroyThis", 2f);
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
}