using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera prevCamera;
    public Camera nextCamera;

    void SwitchToNextCamera()
    {
        prevCamera.enabled = false;
        nextCamera.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SwitchToNextCamera();
        }
    }
}
