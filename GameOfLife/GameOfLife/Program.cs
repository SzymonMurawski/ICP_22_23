// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
runSimulation();


void printGrid(bool[,] grid)
{
    for(int x = 0; x < grid.GetLength(0); x++)
    {
        for(int y = 0; y < grid.GetLength(1); y++)
        {
            // this ternary operator https://letmegooglethat.com/?q=ternary+operator+c%23
            char characterToPrint = grid[x, y] ? '#' : '.';
            Console.Write(characterToPrint);
        }
        Console.WriteLine();
    }
}

// in general this function is not good - we should avoid functions, that modify their arguments
void randomizeGrid(bool[,] grid)
{
    Random random = new Random();
    for (int x = 0; x < grid.GetLength(0); x++)
    {
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            // to easily generate random true/false value, we generate random integer and check if its even (divisible by two)
            bool value = random.Next() % 2 == 0 ? true : false;
            grid[x, y] = value;
        }
    }
}

int howManyNeighbors(bool[,] grid, int x, int y)
{
    int howManyNeighbors = 0;
    int sizeX = grid.GetLength(0);
    int sizeY = grid.GetLength(1);
    // we are interested in nearest neighbors - so we check neighbors with coordinates (x-1, y-1), (x, y-1), (x+1, y-1) ...
    for (int i = -1; i <= 1; i++)
    {
        for (int j = -1; j <= 1; j++)
        {
            // if i,j==0, then we are at the current cell - we don't count it as a neighbor
            if(i == 0 && j == 0)
            {
                continue;
            }
            
            // we are using periodic boundary conditions - grid can be rolled into a torus shape
            int neighborX = (x + i + sizeX) % sizeX;
            int neighborY = (y + j + sizeY) % sizeY;
            
            if(grid[neighborX, neighborY])
            {
                howManyNeighbors++;
            }
        }
    }
    return howManyNeighbors;
}

bool nextCellState(int numberOfNeighbors, bool currentCellState)
{
    // alive cell with 2 or 3 neighbors continues to live
    if (currentCellState && (numberOfNeighbors == 2 || numberOfNeighbors == 3))
    {
        return true;
    }
    // dead cell with exactly 3 neighbors springs to life
    if(!currentCellState && numberOfNeighbors == 3)
    {
        return true;
    }
    // cell dies due to over- or under-population
    return false;
}

bool[,] nextGrid(bool[,] grid)
{
    bool[,] newGrid = new bool[grid.GetLength(0), grid.GetLength(1)];
    for (int x = 0; x < grid.GetLength(0); x++)
    {
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            bool cellState = grid[x, y];
            int cellAliveNeighbors = howManyNeighbors(grid, x, y);
            newGrid[x, y] = nextCellState(cellAliveNeighbors, cellState);
        }
    }
    return newGrid;
}

void runSimulation()
{
    bool[,] grid = new bool[20, 20];
    randomizeGrid(grid);
    int generationNumber = 1;
    while (true)
    {
        //Console.Clear();
        // We use SetCursorPosition instead of Clear, to prevent "blinking" https://stackoverflow.com/questions/5435460/console-application-how-to-update-the-display-without-flicker
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Generation {generationNumber}");
        printGrid(grid);
        grid = nextGrid(grid);
        generationNumber++;
        // We wait for 500ms before next iteration of the loop. Otherwise we wouldn't get nice animation
        Thread.Sleep(500);
    }
}
