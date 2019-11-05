using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARACTERLOAD : MonoBehaviour
{
    public GameObject daveprefab;
    public GameObject fjordprefab;
    public GameObject karenprefab;
    public GameObject tbdprefab;
    public string Character;

    void Start()
    {

        Debug.Log(PlayerPrefs.GetString("character"));
        Character = PlayerPrefs.GetString("character");
        if (Character == "dave")
        {
            GameObject player = Instantiate(daveprefab, transform.position, Quaternion.identity);
        }
        else if (Character == "fjord")
        {
            GameObject player = Instantiate(fjordprefab, transform.position, Quaternion.identity);
        }
        else if (Character == "karen")
        {
            GameObject player = Instantiate(karenprefab, transform.position, Quaternion.identity);
        }
        else if (Character == "tbd")
        {
            GameObject player = Instantiate(tbdprefab, transform.position, Quaternion.identity);
        }
    }
}
