using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject[] levels;
    [SerializeField] GameObject[] lighting;
    public void Respawn()
    {
        if (lighting[0].activeSelf)
        {
            levels[0].SetActive(true);
            for (int i = 1; i < 6; i++)
            {
                levels[i].SetActive(false);
            }
        }
        else
        {
            levels[5].SetActive(true);
            for (int i = 0; i < 5; i++)
            {
                levels[i].SetActive(false);
            }
        }
    }
}
