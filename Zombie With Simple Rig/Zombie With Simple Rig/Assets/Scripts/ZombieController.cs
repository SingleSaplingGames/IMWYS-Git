using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    //VARIABLES
    private bool moving = false;

    //REFERNECES
    [SerializeField] private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("Speed", 1, 0.3f, Time.deltaTime);
        }
    }
}
