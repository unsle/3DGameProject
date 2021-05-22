using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDownController : MonoBehaviour
{
    bool isMove = false;
    private MoveScene moveScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isMove)
            {
                moveScene.Scene();
            }
        }
    }

    //tag로 구분
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "LoadScene")
        {
            isMove = true;
            moveScene = other.GetComponent<MoveScene>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        isMove = false;
        Debug.Log("이동할 수 없습니다!");
    }
}
