using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public bool spawn;

    public Rigidbody2D Rigidbody2D;
    
    public GameObject[] objs;

    public int index;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        if (spawn)
        {
            if (Random.Range(0, 3) == 0)
            {
                index = Random.Range(0, 2);
                
                objs[index].SetActive(true);
            }
        }
    }

    [Button]
    public void Drop(bool right)
    {
        Rigidbody2D.bodyType = RigidbodyType2D.Dynamic;

        transform.parent = null;
        var force = right ? -1 : 1;
        
        Rigidbody2D.AddForce(Vector2.up * speed * 3 + Vector2.right * force * speed);
        
        Destroy(this);
    } 
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
