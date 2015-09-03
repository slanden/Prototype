/******
* Author : Eric Mouledoux
*
*
******/
using UnityEngine;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    public string m_name = "";   // card properties
    public string m_cArea = "";   // what makes a card

    void MoveCard(string from, string to)
    {
        if (to != from)         // checks to see if the card actually moved
        {                       // if yes..
            to = to.ToLower();                                              // make sure the end are is correctly formatted
            List<GameObject> temp = null;                                   //
            if (TableManager.instance.m_table.TryGetValue(to, out temp))    // and make sure the end area exist
            {                                                               // if yes...
                TableManager.instance.m_table[to].Add(gameObject);          // add card to new area
                TableManager.instance.m_table[from].Remove(gameObject);     // and remove it from the old one
                m_cArea = to;                                               // set current area to new area

                switch (m_cArea)                                            // checks what area card was just moved to
                {                                                           //
                    case "deck":                                            //
                        transform.parent = TableManager.instance.deck_pos;  //
                        break;                                              //
                    case "hand":                                            //
                        transform.parent = TableManager.instance.hand_pos;  //
                        break;                                              //
                    case "field":                                           //
                        transform.parent = TableManager.instance.field_pos; //
                        break;                                              //
                    case "grave":                                           //
                        transform.parent = TableManager.instance.grave_pos; //
                        break;                                              //
                };

                transform.position = transform.parent.transform.position;   // and visually moves it there in 3d space
            }
            //else                                                            // if the area is NOT valid
            //{                                                               //
            //    print("ERROR, PATH " + from.ToUpper() + " DOES NOT EXIST"); // display error
            //}
        }
    }
}
