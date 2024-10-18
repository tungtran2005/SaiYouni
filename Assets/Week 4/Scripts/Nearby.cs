using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    // Start is called before the first frame update
    protected float range = 5f;
    [SerializeField] protected Vector3 enemyNearest;
    [SerializeField] protected Vector2 itemNearest;
    [SerializeField] protected List<Vector3> enemys = new List<Vector3>();
    [SerializeField] protected List<Vector2> items = new List<Vector2>();
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        for (int i = 0; i <5; i++)
        {
            float posX = Random.Range(-range, range);
            float posY = Random.Range(-range, range);
            float posZ = Random.Range(-range, range);
            Vector3 newEnemy = new Vector3(posX, posY,posZ);
            this.enemys.Add(newEnemy);
        }
        // Vị trí của người chơi được cung cấp
        Vector3 playerPos = transform.position;
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        float distanceMin = Mathf.Infinity;
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        foreach(Vector3 pos in enemys)
        {
            float currentDistance = Vector3.Distance(playerPos, pos);
            if(currentDistance < distanceMin)
            {
                distanceMin = currentDistance;
                enemyNearest = pos;
            }
        }
        // Trả về thông tin của kẻ địch gần nhất
        Debug.Log("ke dich gan nhat la : " + enemyNearest);
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        for (int i = 0; i < 10; i++)
        {
            float posX = Random.Range(-range, range);
            float posY = Random.Range(-range, range);
            Vector3 newItem = new Vector2(posX, posY);
            this.items.Add(newItem);
        }
        // Vị trí của người chơi được cung cấp
        Vector2 playerPos = transform.position;
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        float distanceMin = Mathf.Infinity;
        // So sánh để tìm vật phẩm gần nhất
        foreach (Vector2 pos in items)
        {
            float currentDistance = Vector2.Distance(playerPos, pos);
            if (currentDistance < distanceMin)
            {
                distanceMin = currentDistance;
                itemNearest = pos;
            }
        }
        // Trả về thông tin của vật phẩm gần nhất
        Debug.Log("vat pham gan nhat la : " + itemNearest);
    }
}
