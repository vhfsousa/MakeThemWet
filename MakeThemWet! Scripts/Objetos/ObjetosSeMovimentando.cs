using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosSeMovimentando : MonoBehaviour
{ 
    [SerializeField] private Vector2 speed;
    [SerializeField] private Transform[] objects;
    [SerializeField] private float width;
    
    void Start()
    {
        
    }

    void Update()
    {
        foreach (Transform t in objects)
        {
            if(t.position.x < width * (objects.Length-1) * -1)
            {
                t.Translate(new Vector2 (width * objects.Length, 0));
                t.position = new Vector2 (t.position.x, t.position.y);
            }
            
            t.Translate(speed * Time.deltaTime * -1);
        }
    }
}