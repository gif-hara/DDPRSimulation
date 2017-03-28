using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu()]
public class EnemyDatabase : ScriptableObject
{
    [SerializeField]
    private List<Enemy> elements = new List<Enemy>();

    [ContextMenu("重複チェック")]
    private void OverlapCheck()
    {
        var overlaps = this.elements.GroupBy(e => e.Name)
            .Where(e => e.Count() > 1 && e.Key != "")
            .Select(e => e.FirstOrDefault()).ToList();

        if(overlaps.Count <= 0)
        {
            Debug.Log("重複していませんでした！");
        }
        else
        {
            overlaps.ForEach(o => Debug.LogErrorFormat("{0}が重複しています", o.Name));
        }
    }
}
