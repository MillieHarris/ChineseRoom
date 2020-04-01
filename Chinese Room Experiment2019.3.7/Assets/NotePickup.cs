using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePickup : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Image customImage2;
    [SerializeField] private Button customButton;
    [SerializeField] private Text customText;

    void OnTriggerEnter(Collider other)
    {

        if( other.CompareTag("Player") && gameObject.tag == "Shelf")
        { customImage.enabled = true;
            print("helooooo");
            customImage2.enabled = true;
            //customButton.enabled = true;
           // customText.enabled = true;
        }
    }

    public void BackButton()
    { customImage.enabled = false;
        customImage2.enabled = false;
        customButton.enabled = false;
        customText.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            customImage.enabled = false;
            customImage2.enabled = false;
        }
    }
}
