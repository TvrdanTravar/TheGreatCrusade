using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickable;

    public bool first = true;

    pointInfo clickOnScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) return;
            RaycastHit rayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickable))
            {
                if (first == false)
                {
                    clickOnScript.Unselect();
                    clickOnScript.selected = false;
                }
                clickOnScript = rayHit.collider.GetComponent<pointInfo>();

                clickOnScript.selected = !clickOnScript.selected;
                clickOnScript.ClickMe();
                first = false;
            }
        }
    }
}
