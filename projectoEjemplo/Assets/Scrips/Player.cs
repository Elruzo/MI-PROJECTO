using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float positionY = 3f; 
    public float localScaleX = 2f;
    public float speed = 5f;
    public string nameplayer = "mr cube";
    public int hp = 3;
    public int attack = -3;
    void Start()
    {
    transform.position = Vector3.up * positionY; 
    transform.localScale = transform.localScale * localScaleX;
    hp = hp -1;
    Debug.Log(hp);
    Debug.Log("ejecutar start");
    transform.position += Vector3.forward * 2f;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = transform.position + Vector3.forward * Time.deltaTime; 
        Debug.Log("ejecutar Update");
    }
    void Damage(int value){
        hp = hp -value;
    }
    private void MovePlayer(Vector3 direccion){
        transform.position += direccion * speed * Time.deltaTime;
    }
}

