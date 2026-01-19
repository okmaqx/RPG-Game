using System;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int potionHeal = 30;
    [SerializeField] private int potionsCount = 5;
    [SerializeField] private int moveSpeed = 5;
    [SerializeField] private int rotationSpeed = 90;

    private HealthComponent playerHealth;
    private CharacterController controller;

    private void Start()
    {
        playerHealth = GetComponent<HealthComponent>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandlePlayerHealing();
        HandleMove();
    }

    private void HandlePlayerHealing()
    {
        if (Input.GetKeyDown(KeyCode.H) && potionsCount > 0)
        {
            playerHealth.Heal(potionHeal);
            potionsCount--;
        }
    }
    private void HandleMove()
    {
        Vector3 moveVector = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) moveVector.z = 1;
        if (Input.GetKey(KeyCode.S)) moveVector.z = -1;
        if (Input.GetKey(KeyCode.A)) moveVector.x = -1;
        if (Input.GetKey(KeyCode.D)) moveVector.x = 1;

        controller.Move(moveVector * Time.deltaTime * moveSpeed);
        transform.forward = Vector3.Slerp(transform.forward, moveVector, rotationSpeed * Time.deltaTime);
    }

}
