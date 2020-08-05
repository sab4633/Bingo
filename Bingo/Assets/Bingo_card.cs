using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bingo_card : MonoBehaviour
{
    // Start is called before the first frame update
    public Button zero_button;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(zero_button, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
