using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlan : MonoBehaviour
{
    public GameObject[] Plan;
    private int Index = 0;

    public void add()
    {
        if (Index < Plan.Length)
        {
            Plan[Index].SetActive(true);
            Index++;
        }
    }

    public void delete()
    {
        if (Index > 0)
        {
            Index--;
            Plan[Index].SetActive(false);
        }
    }
}
