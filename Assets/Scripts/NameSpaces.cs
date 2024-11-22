using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class NameSpaces : MonoBehaviour
{
    private int m_maxBombs = 1, m_bombsRemaining = 1;
    private float m_bombTimer, m_maxBombTimer = 2f;


    private void Start()
    {
        m_bombsRemaining = m_maxBombs;
        m_bombTimer = m_maxBombTimer;
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
/*            if (m_bombsRemaining != 0)
            {
                Instantiate(m_bomb, m_bombSpawnPoint.transform.position, Quaternion.identity);
                m_bombsRemaining--;
            }*/

            Scene scene = SceneManager.GetActiveScene();
            int index = scene.buildIndex;

            switch (index)
            {
                case 1:
                    Vote();
                    break;
                case 2:
                    BomberDuck();
                    break;
                case 3:
                    BumperDucks();
                    break;
                case 4:
                    DuckLordSays();
                    break;
                case 5:
                    QuickDucks();
                    break;
                case 6:
                    FallingPlatforms();
                    break;
                case 7:
                    SinkingPlatforms();
                    break;
            }
        }
    }

    #region Actions
    private void Vote()
    {

    }

    private void BomberDuck()
    {

    }

    private void BumperDucks()
    {

    }

    private void DuckLordSays()
    {

    }

    private void QuickDucks()
    {

    }

    private void FallingPlatforms()
    {

    }

    private void SinkingPlatforms()
    {

    }
    #endregion

    #region Jump
    //Variables voor de player movement/jump stats
    /*    

        [SerializeField] 
        private float gravityValue = 2f;

        [SerializeField] 
        private float jumpHeight = 1.0f;*/

    /*    private Vector3 playerVelocity;
    private bool groundedPlayer = false;
    private bool jumped = false;*/

    /*    public void OnJump(InputAction.CallbackContext context)
        {
            if (context.performed && groundedPlayer)
            {
                jumped = true;
            }
        }*/

    /*    void Update()
        {
            groundedPlayer = IsGrounded();

            if (jumped && groundedPlayer)
            {
                rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                jumped = false;
            }

        }*/
    /*        if (!groundedPlayer)
        {
            rb.AddForce(Vector3.down * gravityValue * Physics.gravity.y, ForceMode.Acceleration);
        }*/
    /*    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }*/
    #endregion

    private void FixedUpdate()
    {
        if (m_bombsRemaining < m_maxBombs)
        {
            m_bombTimer -= Time.fixedDeltaTime;
            if (m_bombTimer <= 0)
            {
                m_bombTimer = m_maxBombTimer;
                m_bombsRemaining++;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
/*        if (collision.gameObject.CompareTag("Portal"))
        {
            m_canVote = true;
            if (m_portals == null)
            {
                m_portals = collision.gameObject;
            }

        }
        else
        {
            m_portals = null;
            m_canVote = false;
        }*/
    }
}
