///---------------------------------------------------------
/// @file : MoveBoard.cs
/// @Auther : Yuhei Daikoku
/// @Date : 2015-02-05
///---------------------------------------------------------

using UnityEngine;
using System.Collections;

/// <summary>
/// ボードを動かすクラス.
/// </summary>
public class MoveBoard : MonoBehaviour {

	// Boardのスピード
	public float speed = 1;

	/// <summary>
	/// Update is called once per frame.
	/// Updateと違い正確に設定したフレーム数呼ばれる
	/// 物理演算に使うのが吉
	/// </summary>
	void FixedUpdate () {

		// スピード分ボードを進める.
		rigidbody2D.velocity = -Vector2.right * speed;
	}
}
