using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug : MonoBehaviour {

    // ボール
    [SerializeField]
    GameObject ball;

    // ボールの座標
    private Vector3 m_ballPos;

	// Use this for initialization
	void Start () {

        // ボールの座標を取得
        m_ballPos = ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
        // ボールの座標を取得
        m_ballPos = ball.transform.position;

        // ボールに100％Y軸を追従させる【デバッグ】
        transform.position = new Vector3(transform.position.x, m_ballPos.y, transform.position.z);
	}
}
