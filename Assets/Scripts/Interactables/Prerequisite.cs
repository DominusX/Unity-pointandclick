using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour {

    //Switcher watcher
    public Switcher watchSwitcher;
    //
    public bool nodeAccess;
    //if true,  check for item instead
    public bool requireItem;
    //if requireItem is true check this collector
    public Collector  checkCollector;

    public bool Complete
    {
        get
        {
            if (!requireItem)
            {
                return watchSwitcher.state;
            }
            else
            {
               return GameManager.ins.itemHeld.itemName == checkCollector.myItem.itemName;
            }
        }
    }
}
