using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   
   
  [SerializeField] float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to Our Game");
        Debug.Log("You can play with WASD keys");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(xValue*moveSpeed,0,zValue*moveSpeed);
    }
}
    