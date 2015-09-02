using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class onMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerEnterHandler
{

    private bool hover;
 void Start()
    {
        hover = false; // for all cards to not hover in the beginning 
    }
}
