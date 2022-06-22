using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if 문 추가하기(91P ~ 92p)
        // 코드 2-17 변수 범위의 예
        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        Debug.Log(y);
    }
}

// The name 'y' does not exist in the current context 출력되는 코드