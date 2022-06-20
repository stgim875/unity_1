using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //변수와 연산(79p ~ 80p)
        //코드 2-6 변수에 덧셈 결과 대입하기(79p)
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        //코드 2-7 사칙연산하기
        //동일한 변수명을 여러개 사용할 수 없음
        int answer1;
        answer1 = 3- 4;
        Debug.Log(answer1);
        
        int answer2;
        answer2 = 5 * 6;
        Debug.Log(answer2);

        int answer3;
        answer3 = 8 / 4;
        Debug.Log(answer3);

    }


}

