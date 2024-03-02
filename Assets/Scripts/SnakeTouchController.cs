using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnakeTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool m_IsPressed;
    public SnakeMovementController snakeMovementController; 

    public void OnPointerDown(PointerEventData eventData)
    {
        m_IsPressed = true;
        StartCoroutine(Execute());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        m_IsPressed = false;
    }

    private IEnumerator Execute()
    {
        while (m_IsPressed)
        {
            // Вызывайте методы управления змейкой в зависимости от направления
            if (gameObject.name.Contains("Left")) // Проверяем, что это кнопка "влево"
            {
                snakeMovementController.LeftTouchMove();
            }
            else if (gameObject.name.Contains("Right")) // Проверяем, что это кнопка "вправо"
            {
                snakeMovementController.RightTouchMove();
            }

            yield return null; // Даем возможность другим операциям выполняться в текущем кадре
        }
    }
}
