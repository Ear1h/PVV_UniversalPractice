using UnityEngine;
using System.Collections;

public class ChangeSky: MonoBehaviour
{
    [SerializeField] Camera cam;
    private Color[] colors =
    {
        Color.red,
        Color.blue,
        Color.white,
        Color.yellow,
    };

    private void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = colors[0];
        StartCoroutine(Change_Color());
    }

    IEnumerator Change_Color()
    {
        int i = 0;
        while (true)
        {
            cam.backgroundColor = colors[i];
            i++;
            if (i == colors.Length)
            {
                i = 0;
            }

           
            yield return new WaitForSeconds(5f);
        }
    }
}