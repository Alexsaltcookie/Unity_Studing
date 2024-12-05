using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraofplayerController : MonoBehaviour
{
    public Transform Player;
    private float mouseX, mouseY; //����ƶ���ֵ
    public float MouseSensity;//���������
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

