using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1;
    int max = 1000;
    int shoot = 500;
    void Start()
    {
        Debug.Log("Hi bestie - pomyœl o liczbie 1 do 1000...");
        Debug.Log("Czy twoja liczba jest równa/wiêksza/mniejsza od 500???");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest równa/wiêksza/mniejsza od "+shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest równa/wiêksza/mniejsza od " +shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("IZI GG.");
        }

    }
}
