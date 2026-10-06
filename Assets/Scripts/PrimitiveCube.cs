using UnityEngine;

public class PrimitiveCube: MonoBehaviour
{
    // Скорость необходимая для передвижения куба
    public float Speed = 10f;
 
    // Update необходим для вызова в каждом кадре - fps, то есть постоянно
    // transform необходимо для изменения меша (позиции, размер и угол). В данном случае мы поворачиваем куб по координате Y
    // Time.deltatime необходим для плавности, чтобы куб резко не вращался.


    public void Update()
    {
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);
    }
}
