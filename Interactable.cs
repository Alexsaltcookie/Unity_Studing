using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactale : MonoBehaviour //公开的 抽象类别
{
    public string promptMessage;
    // Start is called before the first frame update
    public void BaseInteraction()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //不会编写任何函数
        //示范函数
    }

}
