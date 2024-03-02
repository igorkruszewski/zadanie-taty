int portfel = 0;
const int WartośćTranzakcji = 100;
const int WartośćStraty = 1000;
int WspółczynnikStraty = 100;
const int cel = 100000;

for (int IlośćKupców = 1; portfel < cel; IlośćKupców++)
{
  
    if (IlośćKupców % WspółczynnikStraty==0)
    {
        portfel = portfel - 1000;
    }
    else
    {
        portfel = portfel + WartośćTranzakcji;

    }
    Console.WriteLine("Wartosc portfela: " + portfel + ", kupiec numer: " + IlośćKupców);
}
