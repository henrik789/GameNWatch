    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class BallController : MonoBehaviour
    {

        public List<Transform> positions = new List<Transform>();
        float moveDelay = 0.3f;
        int currentPosition = 0;
        float lastMoveTime;

        //public GameMangaer gameManager;



        void Start()
        {

            transform.position = positions[currentPosition].position;
            //lastMoveTime = Time.time;

            StartCoroutine(Move());
        }

        IEnumerator Move()
        {

            while (true)
            {
                yield return new WaitForSeconds(moveDelay);
                //MoveToNextPosition();
                currentPosition++;
                Debug.Log("Nr: " + currentPosition);

                if (currentPosition >= positions.Count){
                    while (currentPosition > 0)
                    {
                        if (currentPosition != positions.Count)
                        {
                            yield return new WaitForSeconds(moveDelay);
                            Debug.Log("Pause");
                        }

                        currentPosition--;
                        transform.position = positions[currentPosition].position;
                        Debug.Log("Number: " + currentPosition);

                        //lastMoveTime = Time.time;

                    }
                }

                transform.position = positions[currentPosition].position;
            }

        }



        //IEnumerator SwitchDirections(){
        //    Debug.Log("In The Numerator!!");

        //    while (currentPosition > 0)
        //    {
        //        Debug.Log("in the while..");
        //        yield return new WaitForSeconds(moveDelay);

        //        Debug.Log("Number: " + currentPosition);

        //        currentPosition--;

        //        transform.position = positions[currentPosition].position;
        //        //lastMoveTime = Time.time;

        //    }
        //    StartCoroutine(Move());
        //}



        //void MoveToNextPosition(){

        //    currentPosition++;
        //    Debug.Log("Nr: "+ currentPosition);
        //    if (currentPosition >= positions.Count){
        //        Debug.Log("SwitchDirections");
        //        StopCoroutine(Move());
        //        StartCoroutine( SwitchDirections());

        //    }
        //    transform.position = positions[currentPosition].position;

        //}

    }
