using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public float velocidad = 4f; // velocidad del desplazamiento
    // Start is called before the first frame update
     private Rigidbody2D Object;
    void Start()
    {
        this.Object = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        this.Move(Input.GetAxis("Horizontal") * velocidad);
    }
    void Move(float H) {
        if (H > 0) {
            this.Object.velocity = new Vector2(H,this.Object.velocity.y);
        }
    }
}
