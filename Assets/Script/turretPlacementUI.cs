using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turretPlacementUI : MonoBehaviour
{
    public GameObject ui;
    
    public Button btnGun;
    public Button btnBomb;
    public Button btnFreeze;
    bool isGun = false;
    bool isFreeze = false;
    bool isBomb = false;
    // Start is called before the first frame update
    void Start()
    {
        btnGun.onClick.AddListener(ActiverGun);
        btnBomb.onClick.AddListener(ActiverBomb);
        btnFreeze.onClick.AddListener(ActiverFreeze);

    }

    // Update is called once per frame
   
    void ActiverGun()
    {

    }
    void ActiverBomb()
    {

    }
    void ActiverFreeze()
    {

    }
    public void SetTarget()
    {
       
    

       
        ui.SetActive(true);
    }

   
    public void Hide()
    {
        ui.SetActive(false);
    }
    public void Vendre()
    {
       //vendre le batiment selectionner

        
        BuildManager.instance.DeselectNode();
    }

}

   



