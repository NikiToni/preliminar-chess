namespace Banana_Chess
{
    internal class King : FigureRokade
    {
        internal King(ColorsOfFigures color) : 
            base(TypesOfFigures.King, color, new int[] { 1, 0, -1, 0,  0, -1,  0, 1,
                                                         1, 1, -1, -1, 1, -1, -1, 1
                                                                                }, 1) { }
    }
}
