using UnityEngine;

public class DeadCube: MonoBehaviour
{
    // ѕри нажатии на мышь, куб уничтожаетс€ через 2 секунды
    private void OnMouseDown()
    {
        Destroy(gameObject, 2f);
    }
}