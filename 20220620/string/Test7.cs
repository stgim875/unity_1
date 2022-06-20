using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 문자열과 문자열의 연결(83p ~ 84p)
        // 코드 2-11 문자열과 문자열 연결하기
        string str1 = "happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);
    }
}
