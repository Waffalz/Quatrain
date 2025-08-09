using Godot;
using System;
using System.Collections.Generic;

public partial class GameBoardCore : Node
{
    //10x24 grid of blocks
    //Organized as a column (List) of rows (array)
    //Of course, null represents empty spaces
    //Bottom -> Top, Left -> Right
    //Unpopulated rows will simply be empty entries in the List
    //  This is okay because there are no empty rows beneath already populated rows
    //Clearing a line will simply remove that row from the List
    //Optimization talk
    //  Linked list would be faster at row deletions
    //  But then again, inserting a tetrimino at the top of the board will require indexing
    
    List<BlockCore[]> grid;


}
