namespace MyFirstApplication;

// This class uses loops and if statements to sing a song
internal class BottlesofBeer
{

    private int _beerNum = 99;
    private string _word = "bottles";

    public void LetsSing()
    {
        while (_beerNum > 0)
        {
            if (_beerNum == 1)
            {
                _word = "bottles";
            } // end if


            Console.WriteLine($"{_beerNum} {_word} of beer on the wall.");
            Console.WriteLine($"{_beerNum} {_word} of beer.");
            Console.WriteLine("Take one down.");
            Console.WriteLine("Pass it around.");

            _beerNum--;

            if (_beerNum > 0)
            {
                Console.WriteLine($"{_beerNum} {_word} of beer on the wall.");
                Console.WriteLine();
            } // end if
            else
            {
                Console.WriteLine("No more bottles of beer.");
            } // end else

        } // end while

    } // end method

} // end class

