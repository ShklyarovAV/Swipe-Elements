using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardInput : MonoBehaviour
{
    [SerializeField] [Range(0.05f, 1)] private float _minOffsetForSwipe = 0.1f;

    public enum SwipeDirection
    {
        Left,
        Up,
        Right,
        Down,
        Site
    }

    private bool _boardInputActive;
    private Vector2 _oldMousePos;

    public void Initialize()
    {

    }

    private void Update()
    {
        if(!_boardInputActive)
        {
            //return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Tap();
        }
        else if(Input.GetMouseButton(0))
        {
            Hold();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            FinishTap();
        }
    }

    private void Tap()
    {
        _oldMousePos = Input.mousePosition;
    }

    private void Hold()
    {

    }

    private void FinishTap()
    {
        Vector2 newMousePos = Input.mousePosition;

        print(GetSwipeDirection(_oldMousePos, newMousePos));
    }

    #region CalculationDirectionSwipe

    private SwipeDirection GetSwipeDirection(Vector2 startPos, Vector2 endPos)
    {
        if(Vector2.Distance(startPos, endPos) < _minOffsetForSwipe)
        {
            return SwipeDirection.Site;
        }

        if(IsVerticalSwipe(startPos, endPos))
        {
            if(startPos.y > endPos.y)
            {
                return SwipeDirection.Down;
            }
            else
            {
                return SwipeDirection.Up;
            }
        }
        else
        {
            if(startPos.x > endPos.x)
            {
                return SwipeDirection.Left;
            }
            else
            {
                return SwipeDirection.Right;
            }
        }
    }

    private bool IsVerticalSwipe(Vector2 startPos, Vector2 endPos)
    {
        return VerticalMovementDistance(startPos, endPos) > HorizontalMovementDistance(startPos, endPos);
    }

    private float HorizontalMovementDistance(Vector2 startPos, Vector2 endPos)
    {
        return Mathf.Abs(startPos.x - endPos.x);
    }

    private float VerticalMovementDistance(Vector2 startPos, Vector2 endPos)
    {
        return Mathf.Abs(startPos.y - endPos.y);
    }

    #endregion
}
