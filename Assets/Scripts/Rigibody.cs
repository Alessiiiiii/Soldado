using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rigibody : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody Rigidbody;
    public float velocityMagnitude;
    public bool CanJump;
    public int collectedItems;

    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI warningText;
    public TMPro.TextMeshProUGUI WinText;
    public TMPro.TextMeshProUGUI GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        warningText.enabled = false;
        GameOverText.enabled = false;
        Rigidbody = GetComponent<Rigidbody>();
        CanJump = true;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space) && CanJump)

        {

            Rigidbody.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            CanJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque cotra : " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Piso"))
        {
            CanJump = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(GameOverText);
            SceneManager.LoadScene(1);
        }
        if (collision.gameObject.CompareTag("item"))
        {
            
            Destroy(collision.gameObject);
            Debug.Log(WinText);
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.CompareTag("Goal"))
        {
            Destroy(collision.gameObject);

            collectedItems++;
            scoreText.text = collectedItems.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        Debug.Log("Trigger Enter:" + other.gameObject.name);
        if (other.gameObject.CompareTag("Goal"))
        {
            Destroy(other.gameObject);
            collectedItems++;
            scoreText.text = collectedItems.ToString();
        }
        if (other.gameObject.CompareTag("KillZone"))
        {
            warningText.enabled = true;
        }
        if (other.gameObject.CompareTag("item"))
        {
            WinText.enabled=true;
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameOverText.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit:" + other.gameObject.name);


        if (other.gameObject.CompareTag("KillZone"))
        {
            warningText.enabled = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay:" + other.gameObject.name);
    }


}

