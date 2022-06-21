using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 문자열과 숫자의 연결(85p)
        // 코드 2-13 문자열과 숫자의 연결하기
        string str = "happy ";
        int num = 123;

        string message = str + num;
        Debug.Log(message);
    }
}