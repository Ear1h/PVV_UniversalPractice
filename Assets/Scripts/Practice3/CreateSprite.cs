using UnityEngine;

public class CreateSprite : MonoBehaviour
{
    public GameObject sprite;

    private void Start()
    {
        createSprite();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            createSprite();
    }

    void createSprite()
    {
        Instantiate(sprite, Vector2.zero, Quaternion.identity);
    }

}