using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;

    void Start() {

    }

    // Update is called once per frame
    void Update() {


        transform.LookAt(target.transform);
    }
}
