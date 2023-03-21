using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        gameObject.transform.Rotate(0, 0, 1);
    }
    
    private void Move()
    {
        //Sang phải
        if(gameObject.transform.position.x <= 5 && gameObject.transform.position.y >= 0)
        { 
            gameObject.transform.position += new Vector3(5, 0, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(1, 1, 1f);
        }
        //Đi xuống
        if (gameObject.transform.position.x >= 5 && gameObject.transform.position.y >= -5)
        {
            gameObject.transform.position += new Vector3(0, -5, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(2, 2, 2f);
        }
        //Sang trái
        if (gameObject.transform.position.x >= 0 && gameObject.transform.position.y <= -5)
        {
            gameObject.transform.position += new Vector3(-5, 0, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(4, 4, 4f);
        }
        //Đi lên
        if (gameObject.transform.position.x <= 0 && gameObject.transform.position.y <=0 )
        {
            gameObject.transform.position += new Vector3(0, 5, 0) * Time.deltaTime * speed;
            gameObject.transform.localScale = new Vector3(6, 6, 6f);
        }
        else
        {
           
        }
    }
}
