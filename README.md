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

## Add Force
It is a function of rigid body which allows to add force/ physics to moving object change their positon and rotation.

It takes two arg (one optional):
1. The vector denoting force magnitude and direction to be applied  
2. ForceMode (optional) :
    * Force (default): continous changes affected by mass
    * Acceleration : Continous changes not affected by mass
    * Impulse : Instance change affected by mass
    * VelocityChange : Instance change not affected by mass

Effectiveness of the Force applied depends on object's mass and drag
## Add Torque
This function again a part of rigid body applies torque across a specified axis. It has two components:
1. (Torque vector) The axis around which the torque has to be applied (Horizontal,Vertical)/(x,y,z) and magnitude of the torque 
2. The ForceMode same as AddForce
Unity uses Left hand screw rule so torque will added in the upwards direction

Angular drag limits the ease of action by torque.
## Physics Material
Instead of affecting the appearnace of the object these affect the way objects react to physics engine by controlling physics elements like Friction 

Physics materials are added to the object collider and not as individual component

They can be created from the Create menu in the project panel like any material

Components:
1. Dynamic Friction : The frcition applied when the object is moving.
2. Static friction : The friction applied when the object is static .i.e, the force to be applied on the object to change its position from static
3. Bounciness : Controls the bounciness of the object
4. Friction and bounce combine determine how the objects react to other objects with physics material
5. Friction direction lets you choose friction control on axis and dynamic/static friction change friction behaviour across those selcted axis
## Joints
Joints as the name suggest represent joints between two objects. They maintain a fixed or relative position of a GameObject to a point in the game

Types :
1. Fixed joint :
    
     They are similar to parents in a hierarchy fixing an object to a point in the world or aconnected rigid body
    
    Components : 

    * Connected body : The rigid Body it is fixed to 
    * Break force and torque : Minimum force or torque required to break the joint
2. Spring joint:

    The concept behind spring joint is that the object on which it is applied tries to move towards a point that is et in the scene view and the connected rigid body is trying to pull it away from that point and towards it.

    If it is also connected to a rigid body than the space point it is trying to reach is relative to that rigid body rather than the game point.

    Components :
    *    The anchor point is the point where the spring joint connection is.
    * The spring parameter denotes the strength of the spring
    * Damper parameter sets how much the spring will slow down when under motion
    * Min and max distance used to setup dead/inactive zone for string
    * Similar to fixed joint it has break force and torque
3. Hinge joints

    As name suggested most suitable for hinges at door and windows. More similar to the Spring joint

    Component:

        * Connected body
        * Axis about which it rotates
        * Use spring 
Difference between spring and hinge joints is about the usage of motors and limits.
1. Motors : It introduces a velocity to the joint

    * Target Velocity : The velocity at which the hinge joint is trying to rotate at.
    * Force is the force that used to attain and tame the target velocity
    * Free spin if selected will make use of Force only for acceleration an not for decelaration
2. Limits : Sets some limits on the hinge

    * Min/Max : The angle limits on which it rotates
    * Min/mx bounce : The limits on hinge bounce when it reaches it's limit

We also have break force and torque