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