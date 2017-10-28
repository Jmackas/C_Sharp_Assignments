class Coin
{
    private string sideUp; // field

    public Coin() // constructor
    {
        sideUp = “Heads”;
    }

    public void Toss() // a void method
    {
        MessageBox.Show(sideUp);
    }
    public string GetSideUp() // a value-returning method
    {
        return sideUp;
    }
}