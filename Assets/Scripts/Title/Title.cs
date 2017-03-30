using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        // SPACEボタンでゲームシーンへ移動
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }
	}
}
