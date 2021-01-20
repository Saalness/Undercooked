using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_manager : MonoBehaviour
{
    public GameObject ingredientsUI;
    public GameObject raycastpoint;
    public GameObject close;
    Touch touch;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ingredient_box();
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y);
            }
        }
    }

    void Ingredient_box()
    {
        Collider co = hit.collider;
        if (Physics.Raycast(raycastpoint.transform.position, raycastpoint.transform.forward, out hit))
        {
            //Debug.Log("testing");
            if (hit.transform.CompareTag("Ingredient_store"))
            {
                Debug.Log("testing");
                ingredientsUI.SetActive(true);
            }
        }
    }
    public void Tomato()
    {
        Debug.Log("Hey tomato");
    }

}