using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int delayPress = 2;
    private bool canPress = true;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        if (Input.GetKeyDown(KeyCode.Space) && canPress)
        {
            canPress = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("WaitForDelay", delayPress);
        }
       
    }

    void WaitForDelay()
    {
        canPress = true;
    }
}
