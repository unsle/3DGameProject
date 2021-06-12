using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject mage;
    public GameObject knight;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mage()
    {
        Debug.Log("Mage");
        mage.SetActive(true);
        knight.SetActive(false);
    }

    public void Knight()
    {
        Debug.Log("Knight");
        mage.SetActive(false);
        knight.SetActive(true);
    }

}
