using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOntroller : MonoBehaviour
{
    private CharacterController player;//控制器
    public float MoveSpeed;//移动速度
    public float JumpSpeed;
    private float horizontalMove , verticalMove;
    private Vector3 dir;//方向
    public float gravity;//重力
    public Vector3 Grv;//重力
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
