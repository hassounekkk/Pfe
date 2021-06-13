using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    
    public Color curColer;
    public ColorsController colorsController;

    // Start est appel� sur le cadre lorsqu'un script est activ� jour ne soit appel�e pour la premi�re fois.
    void Start()
    {
        colorsController = GameObject.FindObjectOfType<ColorsController>();
    }

    // La mise � jour est appel�e � chaque trame, si MonoBehaviour est activ�.
    void Update()
    {
        curColer = colorsController.curColer;

    }
    //est appel� lorsque l'utilisateur a appuy� sur le bouton de la souris alors qu'il �tait au-dessus du collisionneur.
    private void OnMouseDown()
    {
        SpriteRenderer sp = this.GetComponent<SpriteRenderer>();
        sp.color = curColer;
    }
    

}
