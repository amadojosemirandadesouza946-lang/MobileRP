using UnityEngine;

public class AdvancedMapGenerator : MonoBehaviour {
    public GameObject buildingPrefab;
    public GameObject roadPrefab;
    public GameObject plazaPrefab;
    public int gridX = 12;
    public int gridZ = 12;
    void Start(){
        for(int x=0;x<gridX;x++){
            for(int z=0; z<gridZ; z++){
                var pos = new Vector3(x*12,0,z*12);
                if((x+z)%7==0){
                    Instantiate(plazaPrefab, pos, Quaternion.identity);
                } else {
                    var b = Instantiate(buildingPrefab, pos, Quaternion.identity);
                    b.transform.localScale = new Vector3(8, Random.Range(4,16), 8);
                }
                if(z==gridZ/2){
                    Instantiate(roadPrefab, new Vector3(x*12,0,z*12+6), Quaternion.identity);
                }
            }
        }
    }
}
