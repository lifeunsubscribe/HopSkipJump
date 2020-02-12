using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Vector2 direction;
    public static int HSJ;

    // Start is called before the first frame update
    void Start()
    {
        HSJ = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if(HSJ == 1)
            GetInput();
        Move();

        if (HSJ > 2)
            HSJ = 0;
        else
            HSJ++;
    }

    private void Move()
    {
        transform.Translate(direction * speed);
    }

    private bool Step()
    {
        if (HSJ == 1)
        {
            HSJ++;
            return true;
        }   
        else
        {
            if(HSJ > 2)
                HSJ = 1;
            HSJ++;
            return false;
        }
            
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction += Vector2.up;
            //Step();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction += Vector2.down;
            //Step();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
            //Step();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction += Vector2.right;
            //Step();
        }
    }
}
