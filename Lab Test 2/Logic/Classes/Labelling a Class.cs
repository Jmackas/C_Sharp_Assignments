class Coin
{
    private string sideUp; // field

    /* Constructor */
    public Coin()
    {
        sideUp = “Heads”;
    }

    /* A void method */
    public void Toss()
    {
        MessageBox.Show(sideUp);
    }

    /* A value returning method */
    public string GetSideUp()
    {
        return sideUp;
    }
}