using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invader[] prefabs;
    public int rows = 5;
    public int columns = 11;

    private void Awake()
    {
        for (int row = 0; row < rows; row++)
        {
            float width = 2f * (columns - 1);
            float height = 2f * (rows - 1);

            Vector2 centerOffset = new Vector2(-width * 0.5f, -height * 0.5f);
            Vector3 rowPosition = new Vector3(centerOffset.x, (2f * row) + centerOffset.y, 0f);

            for (int col = 0; col < columns; col++)
            {
                Invader invader = Instantiate(prefabs[row], transform);
                Vector3 position = rowPosition;
                position.x += 2f * col;
                invader.transform.localPosition = position;
            }
        }
    }
}
