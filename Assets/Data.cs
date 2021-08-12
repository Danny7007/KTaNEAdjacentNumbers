public static class Data
{
    public static readonly int[][] horizAdj = new int[][]
    {
        new[] { 1 }, new[] { 0, 2 }, new[] { 1 },
        new[] { 4 }, new[] { 3, 5 }, new[] { 4 },
        new[] { 7 }, new[] { 6, 8 }, new[] { 7 },
                      new int[0]
    };
    public static readonly int[][] vertAdj = new int[][]
    {
        new[] { 3 },    new[] { 4 },    new[] { 5 },
        new[] { 0, 6 }, new[] { 1, 7 }, new[] { 2, 8 },
        new[] { 3 },    new[] { 4, 9 }, new[] { 5 },
                        new[] { 7 }
    };
    public static readonly int[][] horizSets = new int[10][]
    {
        new[] {0, 3, 6, 9 },
        new[] {0, 1, 2, 3 },
        new[] {1, 3, 9 },
        new[] {2, 3, 5, 7 },
        new[] {0, 1, 4, 9 },
        new[] {1, 2, 4, 7, 8},
        new[] {1, 3, 6, 0 },
        new[] {6, 7, 8, 9 },
        new[] {0, 3, 8 },
        new[] {1, 3, 5, 7, 9 },
    };
    public static readonly int[][] vertSets = new int[10][]
    {
        new[] { 3, 4, 5, 6 },
        new[] { 2, 4, 8 },
        new[] { 0, 4, 8 },
        new[] { 3, 4, 6, 8 },
        new[] { 0, 2, 4, 6, 8 },
        new[] { 0, 4, 6, 8, 9},
        new[] { 0, 1, 2, 8, 9},
        new[] { 1, 2, 4, 5, 7, 8},
        new[] { 1, 2, 3, 5, 8},
        new[] { 2, 3, 5, 6, 7, 8},
    };
}
