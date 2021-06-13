using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    
    public Color curColer;
    public ColorsController colorsController;

    // Start est appelé sur le cadre lorsqu'un script est activé jour ne soit appelée pour la première fois.
    void Start()
    {
        colorsController = GameObject.FindObjectOfType<ColorsController>();
    }

    // La mise à jour est appelée à chaque trame, si MonoBehaviour est activé.
    void Update()
    {
        curColer = colorsController.curColer;

    }
    //est appelé lorsque l'utilisateur a appuyé sur le bouton de la souris alors qu'il était au-dessus du collisionneur.
    private void OnMouseDown()
    {
        SpriteRenderer sp = this.GetComponent<SpriteRenderer>();
        sp.color = curColer;
    }
    

}
