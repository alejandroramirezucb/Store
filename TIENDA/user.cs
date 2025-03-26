public class user
{
    private String userName;
    private int userID;
    private String userPassword;
    private bool userAdmin;
    private user nextUser;
    public user (String userName, int userID, String userPassword, bool userAdmin)
    {
        this.userName = userName;
        this.userID = userID;
        this.userPassword = userPassword;
        this.userAdmin = userAdmin;
        this.nextUser = null;
    }
    public String getUserName() {
        return userName;
    }
    public void setUserName(String userName)
    {
        this.userName = userName;
    }
    public int getUserID() {
        return userID;
    }
    public void setUserID(int userID)
    {
        this.userID = userID;
    }
    public String getUserPassword() {
        return userPassword;
    }
    public void setUserPassword(String userPassword)
    {
        this.userPassword = userPassword;
    }
    public bool getUserAdmin()
    {
        return userAdmin;
    }
    public void setUserAdmin(bool userAdmin)
    {
        this.userAdmin = userAdmin;
    }
    public user getNextUser()
    {
        return nextUser;
    }
    public void setNextUser(user nextUser)
    {
        this.nextUser = nextUser;
    }
}