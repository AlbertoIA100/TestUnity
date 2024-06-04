using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public int speed;
    public int turnSpeed;
    Vector3 movement; // Variable que almacena la direccion de movimiento

    public Rigidbody rigi;
    public Animator anim;

    float h;
    float v;
    void Start() {


        rigi = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void Update() {

        InputPlayer();
        Animating();
        Attack();   
    }

     void FixedUpdate() {
        MovementRigibody();    
    }

    void InputPlayer() {

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        movement = new Vector3(h, 0, v);
        movement.Normalize();//Normalizamos el vector
    }

    void MovementRigibody() {

        rigi.MovePosition(transform.position + (movement * speed * Time.deltaTime));
    }

    void Animating() {

        if (h != 0 || v != 0) {

            anim.SetBool("isMoving", true);
        }else {
            anim.SetBool("isMoving", false);
        }
    }

    void Attack() {

        if (Input.GetMouseButtonDown(0) && h ==0 && v == 0) {

            anim.SetTrigger("Attack");
        }
    }
    /*   void MovementTransform() {

           * movement = (0,0,1) - Teclas WS
           * movement = (1,0,0) - Teclas AD
           * movement = (1,0,1) - Teclas WD
           * 
          transform.Translate(Vector3.forward * speed * v * Time.deltaTime);
          transform.Translate(Vector3.right * speed * h * Time.deltaTime);
          

    //transform.Translate(movement * speed * Time.deltaTime);

}*/
}
