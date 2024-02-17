using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScene : MonoBehaviour
{
    public int sizeOfForest;
    public int stonesRequired;
    public GameObject[] trees;
    public GameObject[] stones;
    float pyramidBase = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
        CreateGround();
        CreateRandomForest();
        CreatePyramid();
    }

   void InitializeVariables() {
        sizeOfForest = 15;
        stonesRequired = 55;
        trees = new GameObject[sizeOfForest];
        stones = new GameObject[stonesRequired];
   }

   void CreateGround() {
        Debug.Log("Create Ground");

        //creating cube
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground.transform.position = new Vector3(0, -1f, 0);
        ground.transform.localScale = new Vector3(5f, 0.5f, 5f);

        //set color
        var cubeRenderer = ground.GetComponent<Renderer>();
        Color customColor = new Color(1f, 0f, 0f, 1.0f);
        cubeRenderer.material.SetColor("_Color", customColor);
   }

   void CreateRandomForest() {
        Debug.Log("Create Forest");

        //creating shapes
        for(int i = sizeOfForest; i >= 0; i--) {
            //Debug.Log("Forest Number: " + sizeOfForest);

            //creating cylinders
            GameObject trees = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            trees.transform.position = new Vector3(Random.Range(1, 3), 0, Random.Range(1, 3));
            trees.transform.localScale = new Vector3(Random.Range(0.1f, 2), Random.Range(0.1f, 2), Random.Range(0.1f, 2));

            //set color
            var cubeRenderer = trees.GetComponent<Renderer>();
            Color customColor = new Color(0, Random.Range(0.5f, 1), 0f, 1.0f);
            cubeRenderer.material.SetColor("_Color", customColor);
        }
   }

   void CreatePyramid() {
        Debug.Log("Create Pyramid");

        //floor 1 = 5 x 5

        float shiftX = 5f;
        float shiftZ = 5f;
        
        //x value
        
            for(int j = 5; j >=0; j--) {
                //making object
                GameObject stones = GameObject.CreatePrimitive(PrimitiveType.Cube);
                stones.transform.position = new Vector3(shiftX - 5, 0, 0);
                
                //moving down
                shiftX--;
            }
        
        //z value
            for(int i = 5; i >= 0; i--) {

            //making object
            GameObject stones2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            stones2.transform.position = new Vector3(0, 0, shiftZ - 5);
            
            //moving down
            shiftZ--;
            }


   }
}
