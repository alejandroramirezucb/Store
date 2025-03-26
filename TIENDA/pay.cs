public class pay
{
    private bool credit;
    private bool debit;
    private bool cash;

    public pay()
    {
        this.credit = false;
        this.debit = false;
        this.cash = false;
    }
    public bool getCredit()
    {
        return this.credit;
    }
    public void setCredit(bool credit)
    {
        this.credit = credit;
    }
    public bool getDebit()
    {
        return this.debit;
    }
    public void setDebit(bool debit)
    {
        this.debit = debit;
    }
    public bool getCash()
    {
        return this.cash;
    }
    public void setCash(bool cash)
    {
        this.cash = cash;
    }
}        