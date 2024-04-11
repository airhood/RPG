using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody2D rb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        CheckInput();
    }

    private void MovePlayer()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }

    private void CheckInput()
    {
        // 인벤토리 열기, 아이템 사용하기 등 키보드 입력을 처리할 예정
    }
}
