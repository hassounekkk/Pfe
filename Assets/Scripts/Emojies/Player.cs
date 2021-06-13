using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int player;
    EmojiesController emojiesController;
   
    void Start()
    {
        emojiesController = FindObjectOfType<EmojiesController>();
    }

    private void OnMouseDown()
    {
        emojiesController.check(player);
    }


    
    void Update()
    {
        
    }
}
