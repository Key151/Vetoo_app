using UnityEngine;

public class UIControllerMenu : MonoBehaviour
{
    [Header("Telas")]
    [SerializeField] private GameObject menu1;
    [SerializeField] private GameObject menu2;

    public void Start()
    {
        ToMenu1();
    }

    public void ToMenu1()
    {
        if (menu1 is not null) menu1.SetActive(true);
        if (menu2 is not null) menu2.SetActive(false);
    }

    public void ToMenu2()
    {
        if (menu1 is not null) menu1.SetActive(false);
        if (menu2 is not null) menu2.SetActive(true);
    }
}