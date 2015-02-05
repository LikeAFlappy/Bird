///---------------------------------------------------------
/// @file : PlayerController.cs
/// @Auther : Yuhei Daikoku
/// @Date : 2015-02-05
///---------------------------------------------------------

using UnityEngine;
using System.Collections;

/// <summary>
/// プレイヤーコントローラークラス.
/// </summary>
public class PlayerController : MonoBehaviour {

	// ジャンプリクエストされたかされてないか
	private bool isJumpRequest;

	// ジャンプ時のパワー
	public float power = 30;

	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	void Update () {

		// マウスが左クリックされたか
		if( Input.GetMouseButtonDown (0) ){

			// ジャンプのリクエストをTrueに
			isJumpRequest = true;
			
		}
	}

	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	void FixedUpdate(){

		// ジャンプリクエストがTrueなら
		// if(isJumpRequest == true)でもよい
		if (isJumpRequest) {

			// ジャンプリクエストをFalseに戻す
			isJumpRequest = false;

			// 上方向に力を加える
			rigidbody2D.velocity = Vector3.up * power;

		}
	}
}
