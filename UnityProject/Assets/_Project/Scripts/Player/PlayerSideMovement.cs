using UnityEngine;

namespace AslysDisorder.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class PlayerSideMovement : MonoBehaviour
    {
        [Header("Input")]
        [SerializeField] private string horizontalAxis = "Horizontal";

        [Header("Movement")]
        [SerializeField, Min(0f)] private float moveSpeed = 4.5f;

        [Header("Facing")]
        [SerializeField] private Transform facingRoot;
        [SerializeField] private bool startFacingRight = true;

        private Rigidbody2D body;
        private float horizontalInput;
        private int facingDirection;

        public float HorizontalInput => horizontalInput;
        public int FacingDirection => facingDirection;
        public bool IsMoving => Mathf.Abs(horizontalInput) > 0.01f;

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            body.freezeRotation = true;
            body.gravityScale = 0f;

            facingRoot ??= transform;
            facingDirection = startFacingRight ? 1 : -1;
            ApplyFacing();
        }

        private void Update()
        {
            horizontalInput = Mathf.Clamp(Input.GetAxisRaw(horizontalAxis), -1f, 1f);

            if (horizontalInput > 0.01f)
            {
                SetFacing(1);
            }
            else if (horizontalInput < -0.01f)
            {
                SetFacing(-1);
            }
        }

        private void FixedUpdate()
        {
            body.linearVelocity = new Vector2(horizontalInput * moveSpeed, body.linearVelocity.y);
        }

        private void SetFacing(int direction)
        {
            if (direction == facingDirection)
            {
                return;
            }

            facingDirection = direction;
            ApplyFacing();
        }

        private void ApplyFacing()
        {
            Vector3 scale = facingRoot.localScale;
            scale.x = Mathf.Abs(scale.x) * facingDirection;
            facingRoot.localScale = scale;
        }
    }
}
