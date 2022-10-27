namespace task01;

using System.Collections.Generic;

public class Matrix
{
    private List<List<int>> _matrix;
    public static int Min { get; set; }
    public static int Max { get; set; }

    public Matrix(int m, int n)
    {
        _matrix = new List<List<int>>();
        Fill();
    }

    public void Fill()
    {
        Random rnd = new Random();
        for (int i = 0; i < _matrix.Count; i++)
        {
            for (int j = 0; j < _matrix[i].Count; j++)
            {
                _matrix[i][j] = rnd.Next(Min, Max);
            }
        }
    }


    public void ChangeSize(int m, int n)
    {
        Random rnd = new Random();
        var lmatrix = new List<List<int>>();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= _matrix.Count || j >= _matrix.Count)
                {
                    lmatrix[i][j] = rnd.Next(Min, Max);
                }
                else
                {
                    lmatrix[i][j] = _matrix[i][j];
                }
            }
        }
    }
    
    public void ShowPartialy(int m1, int m2, int n1, int n2)
    {
        string text = "";
        for (int i = m1 - 1; i < m2; i++)
        {
            for (int j = n1 - 1; j < n2; j++)
            {
                text += $"{_matrix[i][j]}\t";
            }

            text += '\n';
        }

        Console.WriteLine(text);
    }

    public void Show()
    {
        string text = "";
        for (int i = 0; i < _matrix.Count; i++)
        {
            for (int j = 0; j < _matrix[i].Count; j++)
            {
                text += $"{_matrix[i][j]}\t";
            }

            text += '\n';
        }

        Console.WriteLine(text);
    }

    public int this[int m1, int m2]
    {
        get { return _matrix[m1][m2]; }
        set { _matrix[m1][m2] = value; }
    }
}