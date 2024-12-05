using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraofplayerController : MonoBehaviour
{
    public Transform Player;
    private float mouseX, mouseY; //鼠标移动的值
    public float MouseSensity;//鼠标灵敏度
    public float xRotation;
    private void Update()
    {
        CameraRotation();
    }
    private void CameraRotation()
    {
        mouseX = Input.GetAxis("Mouse X") * MouseSensity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * MouseSensity * Time.deltaTime;
        xRotation -= mouseY;
        Player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}

