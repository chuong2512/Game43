using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using UnityEngine;

public class DirPlayerController : Singleton<DirPlayerController>
{
    public Rigidbody2D Rigidbody2D;
    public Animator animator;
    private bool play;

    public Transform right, left;
    
    public void Play(bool right)
    {
        transform.position = right ? this.right.position : this.left.position;
        transform.rotation = right ? this.right.rotation : this.left.rotation;
        animator.SetTrigger("Tap");
    }
    
    

    public float speed = 2;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("tree"))
        {
            GameManager.Instance.ShowLose();
        }
    }
    
    public void Play()
    {
        play = true;
    }
}