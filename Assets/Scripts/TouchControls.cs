using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    public GameObject obj;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.x < screenBounds.x*2 )
        {
            Destroy(obj);
        }*/

        //onclick destroy
        if (Input.touchCount > 0)
        {
            //Touch touch = Input.GetTouch(0);
            Vector3 objpos = obj.transform.position; //+25 -25
            for (int i = 0; i < Input.touchCount; i++)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
                if ((objpos.x-25)<=touchPosition.x && touchPosition.x<= (objpos.x+25) && (objpos.y-25)<=touchPosition.y && (objpos.y+25)<=touchPosition.y)
                {
                    Destroy(obj);
                    ScorePoints.Scoreplus1();
                }
                //Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
            }
        }
        //display score here
    }
}
