using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public List<Tank> tanklist;
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }
    


    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();   
    }
    
    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tanklist[1].movementSpeed, tanklist[1].rotationSpeed, tanklist[1].tankType, tanklist[1].color);
        TankController tankController = new TankController(tankModel, tankView);

    }

}
