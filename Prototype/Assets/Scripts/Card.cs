using UnityEngine;
using System.Collections.Generic;

public class Card : TableManager
{
    public string m_name    = "";
    public string m_cAera   = "";
    public string m_nArea   = "";

    void MoveCard(string from, string to, int a_index = 0)
    {
        List<GameObject> temp = null;
        if (m_table.TryGetValue(to, out temp))
        {
            print("ERROR, PATH " + from + " DOES NOT EXIST");
        }
        else
        {
            m_table[to].Add(m_table[from][a_index]);
            m_table[from].Remove(gameObject);
        }
    }
}
