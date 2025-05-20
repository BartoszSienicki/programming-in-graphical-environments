public class GraTicTacToe
{
    private string[,] plansza = new string[3, 3];
    public string AktualnyGracz { get; private set; } = "X";

    public GraTicTacToe()
    {
        ResetPlanszy();
    }

    public bool WykonajRuch(int x, int y)
    {
        if (plansza[x, y] != "")
            return false;

        plansza[x, y] = AktualnyGracz;
        return true;
    }

    public string SprawdzWygrana()
    {
        for (int i = 0; i < 3; i++)
        {
            if (plansza[i, 0] != "" && plansza[i, 0] == plansza[i, 1] && plansza[i, 1] == plansza[i, 2])
                return plansza[i, 0];
            if (plansza[0, i] != "" && plansza[0, i] == plansza[1, i] && plansza[1, i] == plansza[2, i])
                return plansza[0, i];
        }

        if (plansza[0, 0] != "" && plansza[0, 0] == plansza[1, 1] && plansza[1, 1] == plansza[2, 2])
            return plansza[0, 0];
        if (plansza[0, 2] != "" && plansza[0, 2] == plansza[1, 1] && plansza[1, 1] == plansza[2, 0])
            return plansza[0, 2];

        return null;
    }

    public bool CzyRemis()
    {
        foreach (var pole in plansza)
            if (pole == "")
                return false;
        return SprawdzWygrana() == null;
    }

    public void ZmienGracza()
    {
        AktualnyGracz = (AktualnyGracz == "X") ? "O" : "X";
    }

    public void ResetPlanszy()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                plansza[i, j] = "";
        AktualnyGracz = "X";
    }
}
