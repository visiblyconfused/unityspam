using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
[CreateAssetMenu]
public class Board : ScriptableObject
{
    [System.Serializable]
    public class SearchingWord 
    {
       public string Word;
    }

    [System.Serializable]

    public class BoardRow
    {
        public int Size;
        public string[] Row;

        public BoardRow() { }

        public BoardRow(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int size)
        {
            Size = size;
            Row = new string[Size];
            ClearRow();
        }

        public void ClearRow()
        {
            for (int i = 0; i < Size; i++)
            {
                Row[i] = " ";
            }
        }
    }

    public int Columns = 0;
    public int Rows = 0;

    public BoardRow[] _Board;

    public void ClearWithEmptyString()
    {
        for(int i = 0; i < Columns; i++)
        {
            _Board[i].ClearRow();
        }
    }

    public void CreateNewBoard()
    {
        _Board = new BoardRow[Columns];
        for(int i=0; i < Columns; i++)
        {
            _Board[i] = new BoardRow(Rows);
        }
    }


}




