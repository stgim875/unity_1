using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 편리한 쓰기 방법 1(81p ~ 82p)
        // 코드 2-9 변수 값 증가시키기
        int answer = 10;
        answer += 5;
        Debug.Log(answer);

        // 편리한 쓰기 방법 2
        // 코드 2-10 값을 1만큼 증가시키기(83p)
        int answer2 = 10;
        answer2++;
        Debug.Log(answer2);

        //answer += 1; 사용하여 1만큼 증가시키기(83p)
        int answer3 = 10;
        answer3 += 1;
        Debug.Log(answer3);

        //answer = answer += 1; 사용하여 1만큼 증가시키기(83p)
        int answer4 = 10;
        answer5 = answer4 += 1;
        Debug.Log(answer5);

        // 변수 값을 1씩 감소시키기(83p)
        int answer6 = 10;
        answer6--;
        Debug.Log(answer6);
    }
}
