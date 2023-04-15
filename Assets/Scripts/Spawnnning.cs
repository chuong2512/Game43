using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class Spawnnning : MonoBehaviour
{
    public GameObject spawnTree;

    // Start is called before the first frame update
    
    

    public Transform lastChild;

    public float posY;
    
    [Button]
    public void Drop(bool right = true)
    {
        transform.DOKill();
        TheLevelTMP.Instance.Add();
        transform.position = new Vector3(transform.position.x, posY);

        var firstChild = GetComponentsInChildren<Tree>()[0];
        firstChild.Drop(right);
        
        posY = transform.position.y - 1.8f;
        
        transform.DOMoveY(posY, 0.8f);
        var tree = Instantiate(spawnTree, transform).transform;
        tree.SetPositionAndRotation(lastChild.position + Vector3.up * 1.8f, lastChild.rotation);
        lastChild = tree;
    }
    
    void Start()
    {
        posY = transform.position.y;
    }
}
