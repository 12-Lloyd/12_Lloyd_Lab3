using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    int score = 0;

    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Healthy"))
        {
            score += 10;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(collision.gameObject);
           
        }
        else if (collision.gameObject.CompareTag("Unhealthy"))
        {
         
            Destroy(collision.gameObject);
            SceneManager.LoadScene("LoseScene");
        }
    }

}
