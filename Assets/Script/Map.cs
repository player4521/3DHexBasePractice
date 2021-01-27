using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject ground5;
    public GameObject ground6;
    public GameObject forest;

    int width = 20;
    int length = 20;
    int height = 3;

    float xOffset = 1f;
    float yOffset = 0.6f;
    float zOffset = 0.866f;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int z = 0; z < length; z++)
                {
                    float xPos = x * xOffset;
                    float yPos = y * yOffset;

                    // 짝수번째 열은 반칸 옆으로 밀어서 맵을 빈틈없이 매움
                    if (z % 2 == 1)
                    {
                        xPos += xOffset / 2f;
                    }

                    // 밑바닥 레이어
                    if (y == 0)
                    {
                        Instantiate(ground5, new Vector3(xPos, yPos, z * zOffset), Quaternion.identity);
                        Debug.Log(xPos + "ground5" + yPos + "," + z * zOffset);
}

                    // 2번째 레이어
                    else if(y == 1)
                    {
                        Instantiate(ground6, new Vector3(xPos, yPos, z * zOffset), Quaternion.identity);
                        Debug.Log(xPos + "ground6" + yPos + "," + z * zOffset);
                    }
                
                    // 이후의 레이어
                    else
                    {
                        Instantiate(forest, new Vector3(xPos, yPos, z * zOffset), Quaternion.identity);
                        Debug.Log(xPos + "forest" + yPos + "," + z * zOffset);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
