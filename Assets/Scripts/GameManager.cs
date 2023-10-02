using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button changeBut;
    [SerializeField] private GameObject capsule;


    void Start()
    {
        changeBut.onClick.AddListener(ChangeState);
    }

    void ChangeState()
    {
        capsule.SetActive(!capsule.activeSelf);
    }
}
