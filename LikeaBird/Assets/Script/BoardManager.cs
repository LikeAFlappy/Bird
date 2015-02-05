///---------------------------------------------------------
/// @file : BoardManager.cs
/// @Auther : Yuhei Daikoku
/// @Date : 2015-02-05
///---------------------------------------------------------

using UnityEngine;
using System.Collections;

/// <summary>
/// ボード生成マネージャー.
/// </summary>
public class BoardManager : MonoBehaviour {

	// インスペクターからボードプレファブを指定する
	public GameObject board = null;

	// 次回生成までの時間.
	float nextSpawnTime = 0;

	// 生成間のインターバル
	float interval = 4;
	
	/// <summary>
	///  Update is called once per frame.
	/// </summary>
	void Update () {

		// ロードされてからの時間が次の生成時間を越えたら
		if( nextSpawnTime < Time.timeSinceLevelLoad)
		{
			// 生成されたときの時間にインターバルを足して次の生成時間とする
			nextSpawnTime = Time.timeSinceLevelLoad + interval;

			// ボードオブジェクトの生成
			LocalInstantate();
			
		}
	}

	/// <summary>
	/// ボードオブジェクトの生成.
	/// </summary>
	void LocalInstantate(){

		// プレファブからゲームオブジェクトを生成する
		GameObject obj = (GameObject)GameObject.Instantiate(board) ;

		// ゲームオブジェクトの親を自分自身に設定
		obj.transform.parent = transform;
		
		
		
		// 高さをランダムに設定.
		float y = Random.Range (1.5f, -0.5f);

		// 初期位置を設定する
		obj.transform.localPosition = new Vector3(10f, y, 0);

	}

	/// <summary>
	/// 当たり判定から抜けたら.
	/// </summary>
	void OnTriggerExit2D (Collider2D cal)
	{
		// 当たり判定から抜けたオブジェクトを消去.
		Destroy (cal.attachedRigidbody.gameObject);
	}
}
