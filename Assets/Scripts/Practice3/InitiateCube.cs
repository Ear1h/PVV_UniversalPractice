using UnityEngine;

public class InitiateCube : MonoBehaviour
{
    [SerializeField] GameObject Cube;
    private void Start()
    {
        Instantiate(Cube, new Vector3(0, 0, 0), Quaternion.identity);
    }
}