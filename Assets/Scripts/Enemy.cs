using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Enemy
{
	/// <summary>
	/// 名前
	/// </summary>
    public string Name;

	/// <summary>
	/// 素点を加算するか
	/// </summary>
	/// <remarks>
	/// 中ボスやボスは加算されないのでその場合は<c>false</c>にする
	/// </remarks>
    public bool addPoint = true;

    /// <summary>
    /// 素点
    /// </summary>
    public List<int> Points;
}
