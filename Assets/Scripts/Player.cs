using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D rb;
    public float moveSpeed;

    public const float diagonalMove = 0.7071067f; // ��Ʈ2����1

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
        // �κ��丮 ����, ������ ����ϱ� �� Ű���� �Է��� ó���� ����
    }
}
