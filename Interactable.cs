using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactale : MonoBehaviour //������ �������
{
    public string promptMessage;
    // Start is called before the first frame update
    public void BaseInteraction()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //�����д�κκ���
        //ʾ������
    }

}
