//using Unity.Collections;
//using Unity.Entities;
//using Unity.Mathematics;
//using Unity.Physics;
//using Unity.Transforms;

//public partial class AIControllerSystem : SystemBase
//{
//    protected override void OnUpdate()
//    {
//        PhysicsWorld physicsWorld = SystemAPI.GetSingleton<PhysicsWorldSingleton>().PhysicsWorld;
//        NativeList<DistanceHit> distanceHits = new NativeList<DistanceHit>(Allocator.TempJob);

//        foreach (var (characterControl, aiController, localTransform) in SystemAPI.Query<RefRW<ThirdPersonCharacterControl>, AIController, LocalTransform>())
//        {
//            // Clear our detected hits list between each use
//            distanceHits.Clear();

//            // Create a hit collector for the detection hits
//            AllHitsCollector<DistanceHit> hitsCollector = new AllHitsCollector<DistanceHit>(aiController.DetectionDistance, ref distanceHits);

//            // Detect hits that are within the detection range of the AI character
//            PointDistanceInput distInput = new PointDistanceInput
//            {
//                Position = localTransform.Position,
//                MaxDistance = aiController.DetectionDistance,
//                Filter = new CollisionFilter { BelongsTo = CollisionFilter.Default.BelongsTo, CollidesWith = aiController.DetectionFilter.Value },
//            };
//            physicsWorld.CalculateDistance(distInput, ref hitsCollector);

//            // Iterate on all detected hits to try to find a human-controlled character...
//            Entity selectedTarget = Entity.Null;
//            for (int i = 0; i < hitsCollector.NumHits; i++)
//            {
//                Entity hitEntity = distanceHits[i].Entity;

//                // If it has a character component but no AIController component, that means it's a human player character
//                if (SystemAPI.HasComponent<ThirdPersonCharacterComponent>(hitEntity) && !SystemAPI.HasComponent<AIController>(hitEntity))
//                {
//                    selectedTarget = hitEntity;
//                    break; // early out
//                }
//            }

//            // In the character control component, set a movement vector that will make the ai character move towards the selected target
//            if (selectedTarget != Entity.Null)
//            {
//                characterControl.ValueRW.MoveVector = math.normalizesafe(SystemAPI.GetComponent<LocalTransform>(selectedTarget).Position - localTransform.Position);
//            }
//            else
//            {
//                characterControl.ValueRW.MoveVector = float3.zero;
//            }
//        }
//    }
//}

//private float speed = 2.0f;
//public GameObject character;

//void Update () {
		
//		if (Input.GetKey(KeyCode.RightArrow)){
//			transform.position += Vector3.right * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.LeftArrow)){
//			transform.position += Vector3.left* speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.UpArrow)){
//			transform.position += Vector3.forward * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.DownArrow)){
//			transform.position += Vector3.back* speed * Time.deltaTime;
//		}
//

//using UnityEngine;
// using System.Collections;
// using System.Collections.Generic;
 
// [RequireComponent (typeof(Rigidbody))]
// public class PlayerController : MonoBehaviour {
 
//     public float movementSpeed = 5.0f;
 
//     void Start () {
         
//     }
     
//     void Update () {
 
//        Rigidbody rigidbody = GetComponent<Rigidbody>();
 
//         if(Input.GetKey(KeyCode.W)) {
//             transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
//         }
//         else if(Input.GetKey(KeyCode.S)) {
//             rigidbody.position += Vector3.back * Time.deltaTime * movementSpeed;
//         }
//         else if(Input.GetKey(KeyCode.A)) {
//             rigidbody.position += Vector3.left * Time.deltaTime * movementSpeed;
//         }
//         else if(Input.GetKey(KeyCode.D)) {
//             rigidbody.position += Vector3.right * Time.deltaTime * movementSpeed;
//         }
//     }
// }
// 	}