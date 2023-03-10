using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : GameScreen
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
        CanvasGroup.blocksRaycasts = false;

    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
        CanvasGroup.blocksRaycasts = true;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick.Invoke();
    }
}