using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    [SerializeField] private Sprite _front;
    [SerializeField] private Sprite _back;
    [SerializeField] private Sprite _left;
    [SerializeField] private Sprite _right;

    private SpriteRenderer _curentSprite;

    private void Start()
    {
        _curentSprite = GetComponent<SpriteRenderer>();
    }


    public void MoveAnimation(Rigidbody2D player)
    {
        if (player.velocity.x > 0)
            _curentSprite.sprite = _right;
        else if (player.velocity.x < 0)
            _curentSprite.sprite = _left;
        else if (player.velocity.y > 0)
            _curentSprite.sprite = _back;
        else
            _curentSprite.sprite = _front;
    }
}
