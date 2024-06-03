using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slaideris : MonoBehaviour
{

    public Slider slaideris;
    public Slider slaideris2;

    public GameObject displayAttels;


    public void ChangeHeigh()
    {
        float pasreizejaVertiba = slaideris.value;
        float garums = pasreizejaVertiba * 2;
        Vector3 currentScale = displayAttels.transform.localScale;
        displayAttels.transform.localScale = new Vector3(currentScale.x, garums, currentScale.z);
    }

    public void ChangeWidth()
    {
        float pasreizejaVertiba = slaideris2.value;
        float platums = pasreizejaVertiba * 2;
        Vector3 currentScale = displayAttels.transform.localScale;
        displayAttels.transform.localScale = new Vector3(platums, currentScale.y, currentScale.z);
    }
}
