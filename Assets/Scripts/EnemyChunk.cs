using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyChunk
{
	/// <summary>
	/// 敵の名前
	/// </summary>
    public string Name;

	/// <summary>
	/// 出現数
	/// </summary>
    public int Number;

	/// <summary>
	/// 出現開始フレーム
	/// </summary>
    public int Frame;

    /// <summary>
    /// 出現する時間（フレーム）
    /// </summary>
    public int Duration;
}
