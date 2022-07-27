using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private MyInput action;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
        action = new MyInput();
    }

    private void OnEnable()
    {
        action.Enable();
    }
    
    private void OnDisable()
    {
        action.Disable();
    }

    void Update()
    {
        
    }
}
