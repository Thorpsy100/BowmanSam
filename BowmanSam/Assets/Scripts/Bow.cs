using UnityEngine;
using UnityEngine.SceneManagement;

public class Bow : MonoBehaviour
{
    public DragNShoot dragNShoot;

    private void LateUpdate()
    {



        if (Input.GetMouseButton(0))
        {
            transform.right = dragNShoot.distance.normalized;
        }
        else
        {
            Vector2 bowPosition = transform.position;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePosition - bowPosition;
            transform.right = direction;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

    }



    //public void Shoot()
    //{
        //if (GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow == false)
        //{
        //    GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        //    newArrow.transform.parent = transform;
        //}
    //}


}
