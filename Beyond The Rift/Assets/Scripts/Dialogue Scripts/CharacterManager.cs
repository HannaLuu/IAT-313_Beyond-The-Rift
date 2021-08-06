using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Sprite speakerImage1;
    public Sprite speakerImage2;
    public Sprite speakerImage3;
    public Sprite speakerImage4;
    Image myImage;


    // Start is called before the first frame update
    void Start()
    {
        myImage = GetComponent<Image>();
    }

    // Switch speaker sprite through cases
    public void SwitchSpeakerSprite(string _name)
    {
        switch (_name)
        {
            case "Bjorn Ironhand":
                myImage.sprite = speakerImage1;
                break;

            case "Khajiit D'Amelio":
                myImage.sprite = speakerImage2;
                break;

            case "Mjoll D'Amelio":
                myImage.sprite = speakerImage3;
                break;

            case "Rogue Riftwalker Leader":
                myImage.sprite = speakerImage4;
                break;

        }
    }
}
