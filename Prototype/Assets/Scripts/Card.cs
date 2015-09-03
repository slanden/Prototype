using UnityEngine;
using System.Collections.Generic;

public class Card : TableManager
{
    public string m_name    = "";
    public string m_cArea   = "";
    public string m_nArea   = "";
    
    void MoveCard(string from, string to)
    {
        if (to != from)
        {
            to = to.ToLower();
            List<GameObject> temp = null;
            if (m_table.TryGetValue(to, out temp))
            {
                m_table[to].Add(gameObject);
                m_table[from].Remove(gameObject);
                m_cArea = to;
            }
            else
            {
                print("ERROR, PATH " + from + " DOES NOT EXIST");
            }
        }
    }

    void Update()
    {
        MoveCard(m_cArea, m_nArea); 
    }
}
