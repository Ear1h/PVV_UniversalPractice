using UnityEngine;


// Данный скрипт должен иметь по умолчанию обязательный компонент
[RequireComponent(typeof(Rigidbody))] 
public class Jumper: MonoBehaviour
{
    public float Force = 300f; // Сила прыжка

    protected Rigidbody rb; // Экземпляр Rigidbody

    public void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Присваиваем rb компонент Rigidbody
    }

    public void FixedUpdate() //Необходима для физики. 
    {
        // Проверяем нажатие кнопки, отвечающий за Space, а также скорость по высоте в 0)
        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0) 
        {
            rb.AddForce(Vector3.up * Force, ForceMode.Acceleration); // Толкаем объект вверх
        }
    }
}
