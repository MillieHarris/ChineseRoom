using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateOutput : MonoBehaviour
{

    public GameObject finalOutput;
    public GameObject X;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutputClick()
    {

        finalOutput.SetActive(true);

    }

    public void WrongClickFunc()
    { StartCoroutine("WrongClick"); }

      public IEnumerator WrongClick()
         {
              X.SetActive(true);
              yield return new WaitForSeconds(1);
              X.SetActive(false);

          }
}
