using UnityEngine;

public class BallManager : MonoBehaviour
{
    public float speedX = 5f; 
    public float speedY = 5f;  


    public float left = -8f;
    public float right = 8f;
    public float top = 4.5f;
    public float bottom = -4.5f;

    void Start()
    {
        speedX = Random.Range(-5f, 5f);
        speedY = -Mathf.Abs(speedY);      
    }
    void Update()
    {
    
        Vector3 pos = transform.position;

       
        pos.x += speedX * Time.deltaTime;
        pos.y += speedY * Time.deltaTime;

       
        if (pos.x <= left || pos.x >= right)
        {
            speedX = -speedX; 
        }

     
        if (pos.y >= top || pos.y <= bottom)
        {
            speedY = -speedY; 
        }

        transform.position = pos;
    }
}
