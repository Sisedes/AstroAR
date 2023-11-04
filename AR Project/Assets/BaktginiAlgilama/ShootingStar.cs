using UnityEngine;
using UnityEngine.UI;

public class ShootingStar : MonoBehaviour
{
    public Image imageToMove;
    public float moveSpeed = 100f;

    private RectTransform rectTransform;
    private Vector2 startPosition; 
    private Vector2 endPosition;
    private bool isMoving = false;
    public float rotationSpeed = 360f;

    void Start()
    {
        rectTransform = imageToMove.GetComponent<RectTransform>();
        startPosition = new Vector2(-transform.position.x,transform.position.y);
        endPosition = new Vector2(Screen.width - rectTransform.rect.width, -(Screen.height - rectTransform.rect.height));
        rectTransform.anchoredPosition = startPosition;
    }

    void Update()
    {
        if (!isMoving)
        {
            int x = Random.Range(0, 50001);
            if (x % 1000 == 0)
            {
                isMoving = true;
                Debug.Log("Random number divisible by 1000: " + x);
            }
        }

        if (isMoving)
        {
            rectTransform.anchoredPosition = Vector2.MoveTowards(rectTransform.anchoredPosition, endPosition, moveSpeed * Time.deltaTime);

            rectTransform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

            if (rectTransform.anchoredPosition == endPosition)
            {
                isMoving = false;
                rectTransform.anchoredPosition = startPosition;
            }
        }
    }
}
