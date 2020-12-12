﻿using UnityEngine;
using UnityEngine.UI;

public enum ButtonType
{
    START_GAME,
    END_GAME
}

[RequireComponent(typeof(Button))]
public class ButtonController : MonoBehaviour
{
    public ButtonType buttonType;

    CanvasManager canvasManager;
    Button menuButton;

    private void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
        canvasManager = CanvasManager.GetInstance();
    }

    void OnButtonClicked()
    {
        switch (buttonType)
        {
            case ButtonType.START_GAME:
                //Call other code that is necessary to start the game like levelManager.StartGame()
                canvasManager.SwitchCanvas(CanvasType.StartMenu);
                break;
            case ButtonType.END_GAME:
                //Do More Things like SaveSystem.Save()
                canvasManager.SwitchCanvas(CanvasType.EndScreen);
                break;
            default:
                break;
        }
    }
}