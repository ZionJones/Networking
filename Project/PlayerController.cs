using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
  {
    public float speed;
    public Text countText;
    public Text WinText;
    public Text LoseText;
    
    private Rigidbody rb;
   //declares the count variable
    private int count;

    void Start()
    {
     //reads and inputs code into the rigibody component
     rb = GetComponent<Rigidbody>();
     count = 0;
     SetCountText();
     WinText.text = "";
     LoseText.text = "";
    }
    private void FixedUpdate()
    {
     // Input keyboard arrow commands
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
     // adjust the vectoe for 3d game objects
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
  // This code activate when the player object collideswith a trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
         //calcualtes how much the counter goes up by
            count = count + 1;
            SetCountText();      
        }

    }
  //This line of code takes the new cout amount and display it to the counter display string
    void SetCountText()
    {
      countText.text = "Count: " + count.ToString();
        if (count >= 10)
        { //Display WInner on screen when player collects all pick up objects
            WinText.text = "Winner";
        }
    }

 





} 