using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    private CharacterController player;//������
    public float MoveSpeed;//�ƶ��ٶ�
    public float JumpSpeed;
    private float horizontalMove , verticalMove;
    private Vector3 dir;//����
    public float gravity;//����
    public Vector3 Grv;//����
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask GroundLayer;
    public bool isGround;
     
    private void Start()
    {
        player = GetComponent<CharacterController>();
        
    }
    private void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, checkRadius,GroundLayer);
        if(isGround && Grv.y < 0)
        {
            Grv.y = -2f;
        }
        horizontalMove = Input.GetAxis("Horizontal") * MoveSpeed;
        verticalMove = Input.GetAxis("Vertical") * MoveSpeed;
        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        player.Move(dir * Time.deltaTime);
        Grv.y -= gravity * Time.deltaTime;
        player.Move(Grv * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGround)
        {
            Grv.y= JumpSpeed;
        }
        
    }

}
