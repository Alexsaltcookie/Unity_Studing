using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Camera PlayerCamera;
    [SerializeField]
    private float RayDistance;
    [SerializeField]
    private LayerMask Mask;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward);
        Debug.DrawRay(ray.origin,ray.direction * RayDistance);//����
        RaycastHit Hitinfo;//��ײ��Ϣ
        if(Physics.Raycast(ray, out Hitinfo, RayDistance, Mask))
        {
            if (Hitinfo.collider.GetComponent<Interactale>() != null)//���
            {
                Debug.Log(Hitinfo.collider.GetComponent<Interactale>().promptMessage);//����
            } 
        }
    }
}
