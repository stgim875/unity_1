using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if ~ else 문으로 조건 분기하기(88P ~ 89p)
        // 코드 2-15 if ~ else 문 사용하기 1
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("공격");
        }
        else
        {
            Debug.Log("방어");
        }
    }
}