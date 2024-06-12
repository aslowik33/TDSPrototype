using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    private Rigidbody2D screen;
    void Start()
    {
        screen = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
