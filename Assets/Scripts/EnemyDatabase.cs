using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class EnemyDatabase : ScriptableObject
{
    [SerializeField]
    private List<Enemy> elements = new List<Enemy>();
}
