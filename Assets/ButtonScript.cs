using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int counter = 0;  

    void Start()
    {
        counter = 1;
    }

    public void OnClickFef()
    {
        switch(counter)
        {
            case 1:
                transform.position = new Vector3(transform.position.x -100,transform.position.y-610);
                counter ++ ;
            break;

            case 2:
                transform.position = new Vector3(transform.position.x +300,transform.position.y+740);
                counter ++ ;
            break;
            case 3:
                transform.position = new Vector3(transform.position.x -600,transform.position.y+1350);
                counter ++ ;
            break;
            case 4:
            SceneManager.LoadScene("Next");
            break;
        }
    }
}
