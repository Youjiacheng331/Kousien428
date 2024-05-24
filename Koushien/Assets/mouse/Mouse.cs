using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    Vector3 MousePos;

    public bool Catch;

    // Start is called before the first frame update
    void Start()
    {
        Catch = false;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        MousePos.z = 0.0f;

        transform.position = MousePos;


        if (Catch == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                transform.GetChild(0).gameObject.GetComponent<Ball>().CheckAbsorption();

                Catch = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Ball"))  
        {
            if (Input.GetMouseButton(0) && Catch == false) 
            {
                collision.gameObject.transform.SetParent(this.gameObject.transform);
                Catch = true;
            }
        }
    }
}
