namespace Banana_Chess
{
    internal abstract class MovingFigure : Figure  //name it abstract just to prevet it being initialized accidentally
    {
        protected int currentX = 0;
        protected int currentY = 0;
        protected readonly int[] directions;
        protected int dirIndex;
        protected int currentRange = 0;
        protected readonly int range;

        protected MovingFigure(TypesOfFigures type, ColorsOfFigures color, int[] dir, int range) : base(type, color)
        {
            directions = dir;
            this.range = range;
        }
        
        public override void getPossibleCells(bool[,] outArr)
        {
            dirIndex = 0;
            while (dirIndex < directions.Length)
            {
                currentRange = range;
                currentX = positionX + directions[dirIndex];
                currentY = positionY + directions[dirIndex + 1];
                while (currentRange-- > 0 && testIfNextCellIsEmptyAndSetRegard(currentX, currentY, outArr, figureColor))
                {
                    currentX += directions[dirIndex];
                    currentY += directions[dirIndex + 1];
                }
                dirIndex += 2;
            }
        }
    }
}
