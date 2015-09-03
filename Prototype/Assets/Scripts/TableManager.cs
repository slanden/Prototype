using UnityEngine;
using System.Collections.Generic;

public class TableManager : MonoBehaviour
{
    protected Dictionary<string, List<GameObject>> m_table =
        new Dictionary<string, List<GameObject>>();
    public List<GameObject> m_deck = new List<GameObject>();
    public List<GameObject> m_hand = new List<GameObject>();
    public List<GameObject> m_field = new List<GameObject>();
    public List<GameObject> m_grave = new List<GameObject>();

    void Start()
    {
        m_table.Add("deck", m_deck);
        m_table.Add("hand", m_hand);
        m_table.Add("field", m_field);
        m_table.Add("grave", m_grave);
    }
}
