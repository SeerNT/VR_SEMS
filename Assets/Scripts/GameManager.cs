using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button changeBut;
    [SerializeField] private GameObject capsule;

    [SerializeField] private TextMeshProUGUI colCounter;

    private int lives = 10;

    void Start()
    {
        changeBut.onClick.AddListener(ChangeState);
    }

    void ChangeState()
    {
        capsule.SetActive(!capsule.activeSelf);
    }

    public void DecreaseLives()
    {
        lives--;
    }

    void Update()
    {
        colCounter.text = "Collision Lives: " + lives.ToString();
    }
}
