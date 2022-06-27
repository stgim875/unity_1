using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // for 문으로 반복하기
        // 코드 2-19 짝수만 출력하기(95p)
        for (int i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }
    }
}