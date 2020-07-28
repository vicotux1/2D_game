using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour
{
    Animator Anim;
    Rigidbody2D Rb2D;
    float MovX;

    [Header("Salto")]
    [SerializeField] [Range(3.0f, 20.0f)] float Jump=5.0f;
    [SerializeField]bool EnSuelo = true;
    [Header("Mover")]
    //[SerializeField]Transform RefPie;
    [SerializeField][Range (3.0f, 20.0f)] float VelX=3;
    
    [SerializeField] string _Axis_X = "Horizontal";

    void Awake()
    {
        Rb2D = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovX = Input.GetAxis(_Axis_X);
        Rb2D.velocity = Vector2.right*MovX*VelX; //(MovX*VelX, Rb2D.velocity.y);

    }
}
