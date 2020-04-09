using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;


public class MovementController : MonoBehaviour
{
    private Vector2 _movementInput;
    private Vector3 _direction;

    private bool _hasMoved;
    private int vision = 1;

    public Tilemap FogOfWar;

    void Update()
    {
        if (_movementInput.x == 0f)
        {
            _hasMoved = false;
        }
        else if (!_hasMoved)
        {
            _hasMoved = true;
            GetMovementDirection();
        }
    }

    public void GetMovementDirection()
    {
        if (_movementInput.x < 0f)
        {
            if (_movementInput.y > 0f)
            {
                _direction = new Vector3(-0.5f, 0.5f);
            }
            else if (_movementInput.y < 0f)
            {
                _direction = new Vector3(-0.5f, -0.5f);
            }
            else
            {
                _direction = new Vector3(-1f, 0f, 0f);
            }

            this.transform.position += _direction;
            UpdateFogOfWar();
        }
        else if (_movementInput.x > 0f)
        {
            if (_movementInput.y > 0f)
            {
                _direction = new Vector3(0.5f, 0.5f);
            }
            else if (_movementInput.y < 0f)
            {
                _direction = new Vector3(0.5f, -0.5f);
            }
            else
            {
                _direction = new Vector3(1f, 0f, 0f);
            }

            this.transform.position += _direction;
            UpdateFogOfWar();
        }
    }

    public void OnMove(InputValue value)
    {
        _movementInput = value.Get<Vector2>();
        Debug.LogFormat("Move: {0}", _movementInput);
    }

    private void UpdateFogOfWar()
    {
        var currentTile = FogOfWar.WorldToCell(this.transform.position);

        // Clear surrounding tiles
        for (int x = -vision; x <= vision; x++)
        {
            for (int y = -vision; y <= vision; y++)
            {
                FogOfWar.SetTile(currentTile + new Vector3Int(x, y, 0), null);
            }
        }
    }
}
