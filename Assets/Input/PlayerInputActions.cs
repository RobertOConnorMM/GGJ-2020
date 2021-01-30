// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
  public InputActionAsset asset { get; }
  public @PlayerInputActions()
  {
    asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""30396005-27d2-46da-a893-510b3d382f43"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d697d94c-6432-4f5f-b65e-b2b2655b5ec9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""be19b542-dbc6-4843-b414-aa4c233a1ec5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""24db5986-0f5c-4849-ab9c-37a3a56bd152"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""8c52cc59-4971-4274-b474-e90e884e6193"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""b8b10aa6-10a6-4198-ba2c-af2f6c20b4d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8f1d617-eb6d-4186-814e-e16b67b4463b"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""223e7f3b-eeb1-49a2-b7ae-115f21df17ed"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbbb81c4-81ae-44b4-857b-690808c393f9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b923462-b483-4c68-b549-45e3b9f81db6"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""896f2696-e0b4-4984-acfc-2a3ef657912f"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""affef5bf-f99c-4dc5-804f-f93f34cc1127"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""2a747936-e703-40f1-87f8-7a78b5770962"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""03ece791-83e0-4c1d-ab80-0507d90296a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""01045b7c-a564-4b00-83a3-7783dbf13799"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d2772027-86b5-47f5-af42-d62f0548555f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""63f633e6-a184-4732-86e1-c48375824147"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""52794975-89dd-43f7-a786-1a90b29603db"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""41dba644-ea34-4165-9770-9e2f507aa0a0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""efdcede6-11bd-4757-91f5-ec9eb744f203"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cb5abad-c636-40e3-833a-957ec7dc1b2c"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
    // Player
    m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
    m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
    m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
    m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
    m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
    m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
    // UI
    m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
    m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
    m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
    m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
    m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
    m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
    m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
    m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
    m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
    m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
    m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
  }

  public void Dispose()
  {
    UnityEngine.Object.Destroy(asset);
  }

  public InputBinding? bindingMask
  {
    get => asset.bindingMask;
    set => asset.bindingMask = value;
  }

  public ReadOnlyArray<InputDevice>? devices
  {
    get => asset.devices;
    set => asset.devices = value;
  }

  public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

  public bool Contains(InputAction action)
  {
    return asset.Contains(action);
  }

  public IEnumerator<InputAction> GetEnumerator()
  {
    return asset.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Enable()
  {
    asset.Enable();
  }

  public void Disable()
  {
    asset.Disable();
  }

  // Player
  private readonly InputActionMap m_Player;
  private IPlayerActions m_PlayerActionsCallbackInterface;
  private readonly InputAction m_Player_Move;
  private readonly InputAction m_Player_Look;
  private readonly InputAction m_Player_MousePosition;
  private readonly InputAction m_Player_Fire;
  private readonly InputAction m_Player_Action;
  public struct PlayerActions
  {
    private @PlayerInputActions m_Wrapper;
    public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
    public InputAction @Move => m_Wrapper.m_Player_Move;
    public InputAction @Look => m_Wrapper.m_Player_Look;
    public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
    public InputAction @Fire => m_Wrapper.m_Player_Fire;
    public InputAction @Action => m_Wrapper.m_Player_Action;
    public InputActionMap Get() { return m_Wrapper.m_Player; }
    public void Enable() { Get().Enable(); }
    public void Disable() { Get().Disable(); }
    public bool enabled => Get().enabled;
    public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
    public void SetCallbacks(IPlayerActions instance)
    {
      if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
      {
        @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
        @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
        @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
        @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
        @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
        @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
        @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
        @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
        @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
        @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
        @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
        @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
        @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
        @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
        @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
      }
      m_Wrapper.m_PlayerActionsCallbackInterface = instance;
      if (instance != null)
      {
        @Move.started += instance.OnMove;
        @Move.performed += instance.OnMove;
        @Move.canceled += instance.OnMove;
        @Look.started += instance.OnLook;
        @Look.performed += instance.OnLook;
        @Look.canceled += instance.OnLook;
        @MousePosition.started += instance.OnMousePosition;
        @MousePosition.performed += instance.OnMousePosition;
        @MousePosition.canceled += instance.OnMousePosition;
        @Fire.started += instance.OnFire;
        @Fire.performed += instance.OnFire;
        @Fire.canceled += instance.OnFire;
        @Action.started += instance.OnAction;
        @Action.performed += instance.OnAction;
        @Action.canceled += instance.OnAction;
      }
    }
  }
  public PlayerActions @Player => new PlayerActions(this);

  // UI
  private readonly InputActionMap m_UI;
  private IUIActions m_UIActionsCallbackInterface;
  private readonly InputAction m_UI_Navigate;
  private readonly InputAction m_UI_Submit;
  private readonly InputAction m_UI_Cancel;
  private readonly InputAction m_UI_Point;
  private readonly InputAction m_UI_Click;
  private readonly InputAction m_UI_ScrollWheel;
  private readonly InputAction m_UI_MiddleClick;
  private readonly InputAction m_UI_RightClick;
  private readonly InputAction m_UI_TrackedDevicePosition;
  private readonly InputAction m_UI_TrackedDeviceOrientation;
  public struct UIActions
  {
    private @PlayerInputActions m_Wrapper;
    public UIActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
    public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
    public InputAction @Submit => m_Wrapper.m_UI_Submit;
    public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
    public InputAction @Point => m_Wrapper.m_UI_Point;
    public InputAction @Click => m_Wrapper.m_UI_Click;
    public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
    public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
    public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
    public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
    public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
    public InputActionMap Get() { return m_Wrapper.m_UI; }
    public void Enable() { Get().Enable(); }
    public void Disable() { Get().Disable(); }
    public bool enabled => Get().enabled;
    public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
    public void SetCallbacks(IUIActions instance)
    {
      if (m_Wrapper.m_UIActionsCallbackInterface != null)
      {
        @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
        @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
        @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
        @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
        @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
        @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
        @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
        @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
        @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
        @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
        @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
        @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
        @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
        @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
        @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
        @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
        @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
        @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
        @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
        @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
        @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
        @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
        @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
        @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
        @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
        @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
        @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
        @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
        @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
        @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
      }
      m_Wrapper.m_UIActionsCallbackInterface = instance;
      if (instance != null)
      {
        @Navigate.started += instance.OnNavigate;
        @Navigate.performed += instance.OnNavigate;
        @Navigate.canceled += instance.OnNavigate;
        @Submit.started += instance.OnSubmit;
        @Submit.performed += instance.OnSubmit;
        @Submit.canceled += instance.OnSubmit;
        @Cancel.started += instance.OnCancel;
        @Cancel.performed += instance.OnCancel;
        @Cancel.canceled += instance.OnCancel;
        @Point.started += instance.OnPoint;
        @Point.performed += instance.OnPoint;
        @Point.canceled += instance.OnPoint;
        @Click.started += instance.OnClick;
        @Click.performed += instance.OnClick;
        @Click.canceled += instance.OnClick;
        @ScrollWheel.started += instance.OnScrollWheel;
        @ScrollWheel.performed += instance.OnScrollWheel;
        @ScrollWheel.canceled += instance.OnScrollWheel;
        @MiddleClick.started += instance.OnMiddleClick;
        @MiddleClick.performed += instance.OnMiddleClick;
        @MiddleClick.canceled += instance.OnMiddleClick;
        @RightClick.started += instance.OnRightClick;
        @RightClick.performed += instance.OnRightClick;
        @RightClick.canceled += instance.OnRightClick;
        @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
        @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
        @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
        @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
        @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
        @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
      }
    }
  }
  public UIActions @UI => new UIActions(this);
  private int m_KeyboardMouseSchemeIndex = -1;
  public InputControlScheme KeyboardMouseScheme
  {
    get
    {
      if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
      return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
    }
  }
  private int m_GamepadSchemeIndex = -1;
  public InputControlScheme GamepadScheme
  {
    get
    {
      if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
      return asset.controlSchemes[m_GamepadSchemeIndex];
    }
  }
  private int m_TouchSchemeIndex = -1;
  public InputControlScheme TouchScheme
  {
    get
    {
      if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
      return asset.controlSchemes[m_TouchSchemeIndex];
    }
  }
  private int m_JoystickSchemeIndex = -1;
  public InputControlScheme JoystickScheme
  {
    get
    {
      if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
      return asset.controlSchemes[m_JoystickSchemeIndex];
    }
  }
  private int m_XRSchemeIndex = -1;
  public InputControlScheme XRScheme
  {
    get
    {
      if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
      return asset.controlSchemes[m_XRSchemeIndex];
    }
  }
  public interface IPlayerActions
  {
    void OnMove(InputAction.CallbackContext context);
    void OnLook(InputAction.CallbackContext context);
    void OnMousePosition(InputAction.CallbackContext context);
    void OnFire(InputAction.CallbackContext context);
    void OnAction(InputAction.CallbackContext context);
  }
  public interface IUIActions
  {
    void OnNavigate(InputAction.CallbackContext context);
    void OnSubmit(InputAction.CallbackContext context);
    void OnCancel(InputAction.CallbackContext context);
    void OnPoint(InputAction.CallbackContext context);
    void OnClick(InputAction.CallbackContext context);
    void OnScrollWheel(InputAction.CallbackContext context);
    void OnMiddleClick(InputAction.CallbackContext context);
    void OnRightClick(InputAction.CallbackContext context);
    void OnTrackedDevicePosition(InputAction.CallbackContext context);
    void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
  }
}
