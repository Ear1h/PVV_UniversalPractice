using System;
using System.Collections;
using UnityEngine;

public class SphereSpawn: MonoBehaviour
{
    public bool isStop = false;
    public float Delay = 1.5f;
    private Coroutine Spawn;

    [SerializeField] GameObject Sphere;

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            Instantiate(Sphere, new Vector3(UnityEngine.Random.Range(0f, 5f), 0, UnityEngine.Random.Range(0f, 5f)), Quaternion.identity);
            yield return new WaitForSeconds(Delay);
        }
    }

    private void Start()
    {
        Spawn = StartCoroutine(SpawnObjects());
    }

    private void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (!isStop && Spawn != null)
                {
                    StopCoroutine(SpawnObjects());
                    Spawn = null;
                }

                else if (isStop && Spawn == null)
                    Spawn = StartCoroutine(SpawnObjects());

                isStop = !isStop;
            }
        }

    }
}