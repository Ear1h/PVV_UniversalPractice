using UnityEngine;
using System.Collections;

public class LoopSpawn: MonoBehaviour
{
    [SerializeField] GameObject some;

    private void Start()
    {
        StartCoroutine(Make_cube());
    }

    IEnumerator Make_cube()
    {
        while(true)
        {
            Instantiate(some, new Vector3(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
