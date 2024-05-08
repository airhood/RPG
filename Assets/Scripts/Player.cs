using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D rb;
    public float moveSpeed;

    public const float diagonalMove = 0.7071067f; // 루트2분의1

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        print($"x: {x}, y: {y}");

        if ((x != 0) && (y != 0))
        {
            rb.velocity = new Vector2(x * moveSpeed * diagonalMove, y * moveSpeed * diagonalMove);
        }
        else
        {
            rb.velocity = new Vector2(x * moveSpeed, y * moveSpeed);
        }
    }

    private void CheckInput()
    {
        // 인벤토리 열기, 아이템 사용하기 등 키보드 입력을 처리할 예정
    }
}
