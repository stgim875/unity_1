using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //변수 선언하기(74p ~ 75p)
        //코드 2-3 변수 사용하기
        // int age;
        // age = 30;
        // Debug.Log(age);
        
        // 변수 초기화와 대입(76p ~ 77p) 
        // 코드 2-4 변수에 변수대입하기

        // 변수에 문자열 대입(78p)
        // 코드 2-5 변수에 문자열 대입하기
        // string name;
        // name = "Sera";
        // Debug.Log(name);
        
        //변수와 연산(79p ~ 80p)
        //코드 2-6 변수에 덧셈 결과 대입하기(79p)
        // int answer;
        // answer = 1 + 2;
        // Debug.Log(answer);
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

        //변수와 변수의 연산(80p~81p)
        //코드 2-8 변수와 변수 연산하기
        int n1 = 8;
        int n2 = 9;
        int answer; 
        answer = n1 + n2;
        Debug.Log(answer);
    }


}

