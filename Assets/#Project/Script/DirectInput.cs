using UnityEngine;
using UnityEngine.InputSystem;

public class DirectInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    int var = 0;
    void Update()
    {
        Keyboard keyboard = Keyboard.current;
        if( keyboard == null) return;


        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Hello world !");
        }

        if (keyboard.rightArrowKey.isPressed)
        {
            transform.position += Vector3.right * 5 * Time.deltaTime;
        }

        if (keyboard.leftArrowKey.isPressed)
        {
            transform.position -= Vector3.right * 5 * Time.deltaTime;
        }

        if (keyboard.upArrowKey.isPressed)
        {
            transform.position += Vector3.forward * 5 * Time.deltaTime;
        }

        if (keyboard.downArrowKey.isPressed)
        {
            transform.position += Vector3.back * 5 * Time.deltaTime;
        }
        
        if (keyboard.spaceKey.isPressed && var<25)
        {
            
            transform.position += Vector3.up * var * Time.deltaTime;
            var++;
        }
        else
        {
            var=0;
        }

    }
}
