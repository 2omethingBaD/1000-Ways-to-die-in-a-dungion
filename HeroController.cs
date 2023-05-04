using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AC;

public class HeroController : MonoBehaviour
{
    //sets player speed
    [SerializeField] float _playerSpeed = 5f;
    [SerializeField] float _runSpeed = 8f;
    [SerializeField] float _slowSpeed = 2f;

    public Rigidbody2D _rb; //sets up variable for rigid body
    public Vector2 _move;//sets up the player movement
    GVar _isRunning;//defines variable from AC
    GVar _isWalking;
    GVar _isCrouching;
    public bool _freeze;
    /*sets trigger object to stop action list from running when player exits the trigger
     * (hopefully temporary until a shorter solution is found XP)*/
    public GameObject _trig1;
    public GameObject _trig2;
    public GameObject _trig3;
    public GameObject _trig4;
    public GameObject _trig5;
    public GameObject _trig6;
    public GameObject _trig7;
    public GameObject _trig8;
    public GameObject _trig9;
    public GameObject _trig10;
    //to set the specific game object to manipulate
    public GameObject _speekInteract;
    public GameObject _lookInteract;
    public GameObject _useInteract;
    public GameObject _openInteract;


    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        _rb = GetComponent<Rigidbody2D>(); //gets rigid body so you dont have to type whole thing
        _rb.gravityScale = 0; //stops player from falling until set to at least 1
        _isCrouching = AC.GlobalVariables.GetVariable(14);//addresses the variable of 'var' 5 from AC
        _isRunning = AC.GlobalVariables.GetVariable(13);
        _isWalking = AC.GlobalVariables.GetVariable(12);
    }


    //executes when player enters a trigger area 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //adds talk indicator above player
        if (collision.gameObject.tag == "talk")
        {
            _speekInteract.SetActive(true);
        }
        //adds look indicator above player
        if (collision.gameObject.tag == "look")
        {
            _lookInteract.SetActive(true);
        }
        //adds use indicator above player
        if (collision.gameObject.tag == "use")
        {
            _useInteract.SetActive(true);
        }
        //adds open(for doors) indicator above player
        if (collision.gameObject.tag == "open")
        {
            _openInteract.SetActive(true);
        }

        //stops player from moving while in the freeze trigger
        if (collision.gameObject.tag == "freeze")
        {
            _freeze = true;
            Debug.Log("you have entered freeze");
        }
    }


    //executes when player leaves a trigger area 
    private void OnTriggerExit2D(Collider2D collision)
    {
        //hides talk indicator above player
        if (collision.gameObject.tag == "talk")
        {
            _speekInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides look indicator above player
        if (collision.gameObject.tag == "look")
        {
            _lookInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides use indicator above player
        if (collision.gameObject.tag == "use")
        {
            _useInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }
        //hides open(for doors) indicator above player
        if (collision.gameObject.tag == "open")
        {
            _openInteract.SetActive(false);

            _trig1.SetActive(false);
            _trig1.SetActive(true);
            _trig2.SetActive(false);
            _trig2.SetActive(true);
            _trig3.SetActive(false);
            _trig3.SetActive(true);
            _trig4.SetActive(false);
            _trig4.SetActive(true);
            _trig5.SetActive(false);
            _trig5.SetActive(true);
            _trig6.SetActive(false);
            _trig6.SetActive(true);
            _trig7.SetActive(false);
            _trig7.SetActive(true);
            _trig8.SetActive(false);
            _trig8.SetActive(true);
            _trig9.SetActive(false);
            _trig9.SetActive(true);
            _trig10.SetActive(false);
            _trig10.SetActive(true);
        }

        //allows player to move again
        if (collision.gameObject.tag == "freeze")
        {
            _freeze = false;
            Debug.Log("you have left freeze");
        }
    }


    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        if (!_freeze)
        {
            //checks for player movement
            _move.x = Input.GetAxisRaw("Horizontal");
            _move.y = Input.GetAxisRaw("Vertical");
        }
    }


    //is called every 50 frames(better for physics stuffs)
    void FixedUpdate()
    {
        if (!_freeze)
        {
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _rb.MovePosition(_rb.position + _move * _runSpeed * Time.fixedDeltaTime);//actually changes your position for running
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
                {
                    _isRunning.BooleanValue = true;
                    _isCrouching.BooleanValue = false;
                    _isWalking.BooleanValue = false;
                    Debug.Log("you are running");
                }
            }
            else if (Input.GetKey(KeyCode.V))
            {
                _rb.MovePosition(_rb.position + _move * _slowSpeed * Time.fixedDeltaTime);//actually changes your position for creeping
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
                {
                    _isRunning.BooleanValue = false;
                    _isCrouching.BooleanValue = true;
                    _isWalking.BooleanValue = false;
                    Debug.Log("you are crouching");
                }
            }
            else
            {
                _rb.MovePosition(_rb.position + _move * _playerSpeed * Time.fixedDeltaTime);//actually changes your position
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
                {
                    _isRunning.BooleanValue = false;
                    _isCrouching.BooleanValue = false;
                    _isWalking.BooleanValue = true;
                    Debug.Log("you are walking");
                }
            }
        }
    }
}
