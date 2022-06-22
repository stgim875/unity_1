using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if 문 추가하기(90P ~ 91p)
        // 코드 2-16 if ~ else 문 사용하기 2
        int hp = 50; // 50이하/200이상/200이하 체크
        if (hp <= 50) // hp가 50이하인가 확인
        {
            Debug.Log("도망");
        }
        else if (hp >= 200) // hp가 200이상인가 확인
        {
            Debug.Log("공격!");
        }
        else
        {
            Debug.Log("방어"); // 200이하인가 확인
        }
    }
}