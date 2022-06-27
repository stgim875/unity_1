using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if문으로 조건 분기하기(86P ~ 87p)
        // 코드 2-14 if 문 사용하기
        int herbNum = 1;
        if (herbNum == 1)
        {
            Debug.Log("체력을 50 회복");
        }

        // if문으로 조건 분기하기(86P ~ 87p)
        // 코드 2-14 if 문 사용하기
        // 변수 herbNum 값을 5를 입력하여 코드가 실행이 안되는지 확인
        int herbNum1 = 5;
        if (herbNum1 == 1)
        {
            Debug.Log("체력을 50 회복");
        }
    }
}