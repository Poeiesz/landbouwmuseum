using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public GameObject[] objects;

    int id = 0;

    public string type;

    public void ChangeObject()
    {
        id++;
        switch (type) {
            case "Cow":
                switch (id)
                {
                    case 1:
                        objects[0].SetActive(false);
                        break;
                    case 2:
                        objects[0].SetActive(true);
                        id = 0;
                        break;
                }
                break;
            case "Chicken":
                switch (id)
                {
                    case 1:
                        objects[0].SetActive(false);
                        break;
                    case 2:
                        objects[0].SetActive(true);
                        id = 0;
                        break;
                }
                break;
        }
    }
}
