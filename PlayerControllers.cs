using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllers : MonoBehaviour
{
    private int count;
    public Text countText;
    public Text KeyFoundText;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        count = 0;
        counterPoints();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {




        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            counterPoints();

        }
        if (other.CompareTag("Key"))
            {
                other.gameObject.SetActive(false);
                KeyFoundText.text = "Key:FOUND";

            }




    }
     void counterPoints()

    {
        countText.text = "Count: " + count.ToString();
    }

    /*void openDoor()
    {
        
    }
    */
}
