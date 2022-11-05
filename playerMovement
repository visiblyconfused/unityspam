using UnityEngine;

public class playerMovement : MonoBehaviour
{

        public float movementspeed = 1;

        public float jumpforce = 1;

        public Animator animator;

        private Rigidbody2D rb;

        public bool facingleft = false;

        public bool facingright = false;


        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();

        }

        private void Update()
        {

            /// Character movement 


            var movemenet = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movemenet, 0, 0) * Time.deltaTime * movementspeed;

            /// Animator movement 
            /// Speed is a name from animator

            animator.SetFloat("speed", Mathf.Abs(movemenet));

            /// flip character 


            Vector3 characterscale = transform.localScale;
            if (Input.GetAxis("Horizontal") < 0)
            {
                facingleft = true;
                facingright = false;
                characterscale.x = -1f; /// -xf     x = scale the character is currently in. 
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                facingright = true;
                facingleft = false;
                characterscale.x = 1f;
            }
            transform.localScale = characterscale;


            /// Jump

            if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
                animator.SetBool("isjumping", true);

            }
            if (rb.velocity.y == 0)
            {
                animator.SetBool("isjumping", false);

            }

        }

}
