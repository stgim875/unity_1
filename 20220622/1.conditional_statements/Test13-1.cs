using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if 문 추가하기(91P ~ 92p)
        // 코드 2-17 변수 범위의 예
        int x = 1;
        int y = 2;
        if (x == 1)
        {
            Debug.Log(x);
        }
        else if (y == 2)
        {
            Debug.Log(y);
        }
        else { }
    }
}

// 조건식에 and 와 or 조건을 넣지 않았는데 왜? 둘 다 참 일 경우 왜 x가 값만 나오는걸까???