using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems; // for point enter and exit

public class onMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool hover;

    void Start()
    {
        hover = false; // for all cards to not hover in the beginning 
    }

    void Update()
     {

     }

    public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log(gameObject);
            if(hover == false)
            {
                transform.Translate(0,10,0);
                hover = true;
            }
    }

    public void OnPointerExit(PointerEventData data)
    {
        transform.Translate(0, -10, 0);
        hover = false;
    }

}
