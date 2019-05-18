# UnityPhysics
## Colliders
They allow GameObjects they are attached to, react to other colliders, provided that they have a rigid body component too. They are denoted by green lines in the scene view.

The rigid body provides mass and body

Different primitive objects have different type of Colliders :

Shape  |  Collider
------|--------
Sphere | Sphere
Cube | Box
Capsule | Capsule
Cylinder | Cylinder
Terrain | Terrain

Complex object mad up of differernt primitive components can have multiple colliders as well. On the other hand for such scenarios we can use mesh colliders which will the fit exact size of the mesh it is given providing an overly detailed collider

Other way to handle colliders for complex meshses is to seperate their geometry and provide seperate colliders.

When colliders hit each other an event called OnCollisionEnter is invoked. Other events are OnCollisionStay and OnCollisionExit

## Triggers in colider
To make a colliderinto a trigger simply check the Is Trigger option in the collider inspector.
This makes things pass through it rather than colliding and it also enables detection of when and a collider overlaps with this trigger collider

So this could be used for triggering code whenever our GameObject passes through/interacts with a trigger collider without actually colliding

The object entering the trigger is refered to in the callbacks as other

## Rigid Bodies
They provide mass and body to objects and be affected by physics. Moving objects should have a rigid body. It is paired with a collider so as to interact with other physics elements

Components:
1. Mass : It determines collision behaviour. Higher the mass lesser the reaction to collision
2. Drag : How quickly the object slows down without other interaction (i.e on its own). Refers to slowing down linear velocity
3. Angular Drag : Same as drag but for angular velocity like when torque is applied
4. Use gravity : Whether to be affected by gravity or not. Gravity settings can be managed from Edit > Project Settings > Physics and change the gravity along axis
5. is kinematic : determines whether body will react to physics. It will still interact with other bodies but not physics action 
6. Interpolate : Smooth the body transition based on previous frames
7. Extrapolate : Smooth the body transition based on prediction of upcoming frames
8. Collision Detection:

    * Discrete : Used most of the time
    * Continous : For fast moving objects interacting with static geometry
    * Continous dynaimc : like Continous but for interaction with dynamic objects
9. Constraints : Prevent movement and rotation in any axis