///---------------------------------------------------------
/// @file : BackGroundCountroller.cs
/// @Auther : Yuhei Daikoku
/// @Date : 2015-02-05
///---------------------------------------------------------

using UnityEngine;
using System.Collections;

public class BackGroundCoutroller : MonoBehaviour {

	// Scroll Speed
	public float speed = 1;

	// Current pos
	float current;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {

		// 現在の位置に前回とのアップデート誤差（Time.deltaTime）にスピードをかける
		current += Time.deltaTime * speed;

		// テクスチャのオフセットを適応する
		renderer.material.SetTextureOffset("_MainTex", new Vector2(current, 0));
	}
}
