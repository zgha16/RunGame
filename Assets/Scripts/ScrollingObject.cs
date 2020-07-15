﻿using UnityEngine;

// 게임 오브젝트를 계속 왼쪽으로 움직이는 스크립트
public class ScrollingObject : MonoBehaviour {
    public float speed = 10f; // 이동 속도

    private void Update() {
        if (!GameManager.instance.isGameover)
        {
         transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //초당 스피드의 속도로 왼쪽으로 평행이동
       
        // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
    }
}