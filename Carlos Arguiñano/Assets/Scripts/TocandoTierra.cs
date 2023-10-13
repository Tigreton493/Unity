using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobadorTiera : MonoBehaviour
{

    public MovimientoPersonaje PlayerMove;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMove = FindFirstObjectByType<MovimientoPersonaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMove.Onground = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerMove.Onground = false;
    }
}
