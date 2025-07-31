
namespace CardGameApp
{

    class CardGame
    {

        static string titleCard = """
          ___   __   ____  ____     ___   __   _  _  ____ 
         / __) / _\ (  _ \(    \   / __) / _\ ( \/ )(  __)
        ( (__ /    \ )   / ) D (  ( (_ \/    \/ \/ \ ) _) 
         \___)\_/\_/(__\_)(____/   \___/\_/\_/\_)(_/(____)

""";

        static void Main(string[] args)
        {

            Console.WriteLine(titleCard);
            debug();
        }

        private static void debug()
        {

            Console.WriteLine("\nBritish Cards");
            foreach (var suite in BritishSuite.All)
            {
                Console.WriteLine($"-{suite}");
            }

            Console.WriteLine("\nBritish Ranks");
            foreach (var rank in BritishRank.All)
            {
                Console.WriteLine($"-{rank}");
            }
        }
    } 
} 
