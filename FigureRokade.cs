namespace Banana_Chess
{
    internal abstract class FigureRokade : MovingFigure
    {
        internal FigureRokade(TypesOfFigures type, ColorsOfFigures color, int[] dirArr, int range) : 
            base(type, color, dirArr, range) { }

        protected bool moved = false;

        public override void getPossibleCells(bool[,] arr)
        {
            base.getPossibleCells(arr);
            if (moved)
            {
                //code for rokade
                if (figureType == TypesOfFigures.King)
                {

                }
                else
                {

                }
            }
            moved = true; //no virgin anymore!! nover be virgin again!!
        }
    }
}
