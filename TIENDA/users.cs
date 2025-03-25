using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class users
{
    private user userFirst;
    private int adminUsersCount;
    private int customeUsersCount;
    private int usersCount;

    public int getAdminUsersCount()
    {
        return adminUsersCount;
    }
    public void setAdminUsersCount(int adminUsersCount)
    {
        this.adminUsersCount = adminUsersCount;
    }
    public int getCustomeUsersCount()
    {
        return customeUsersCount;
    }
    public void setCustomeUsersCount(int customeUsersCount)
    {
        this.customeUsersCount = customeUsersCount;
    }
    public int getUsersCount()
    {
        return usersCount;
    }
    public void setUsersCount(int usersCount)
    {
        this.usersCount = usersCount;
    }
    public bool ifUserIDExists(int userID)
    {
        user auxUser = userFirst;
        while (auxUser != null)
        {
            if (auxUser.getUserID() == userID)
            {
                return true;
            }
            auxUser = auxUser.getNextUser();
        }
        return false;
    }
    public bool addUser(string userName, int userID, string userPassword, bool userAdmin)
    {
        user newUser = new user(userName, userID, userPassword, userAdmin);
        if (ifUserIDExists(userID))
        {
            Console.WriteLine("ERROR: El ID del Usuario ya existe");
            return false;
        }
        else if (userFirst == null)
        {
            userFirst = newUser;
            return true;
        }
        else
        {
            user auxUser = userFirst;
            while (auxUser.getNextUser() != null)
            {
                auxUser = auxUser.getNextUser();
            }
            auxUser.setNextUser(newUser);
            if (newUser.getUserAdmin() == true)
            {
                setAdminUsersCount(getAdminUsersCount() + 1);
            }
            else
            {
                setCustomeUsersCount(getCustomeUsersCount() + 1);
            }
            setUsersCount(getUsersCount() + 1);
            return true;
        }
    }
    public bool delUser(int userID)
    {
        user auxUser = userFirst;
        if (userFirst == null)
        {
            return false;
        }
        else if (userFirst.getUserID() == userID)
        {
            userFirst = userFirst.getNextUser();
            return true;
        }
        else
        {
            while (auxUser.getNextUser() != null)
            {
                if (auxUser.getUserID() == userID)
                {
                    auxUser.setNextUser(auxUser.getNextUser().getNextUser());
                    return true;
                }
                auxUser = auxUser.getNextUser();
            }
            return false;
        }
    }
    public user getUserByID(int userID)
    {
        user auxUser = userFirst;
        while (auxUser != null)
        {
            if (auxUser.getUserID() == userID)
            {
                return auxUser;
            }
            auxUser = auxUser.getNextUser();
        }
        return null;
    }
    public void printUserAdmin()
    {
        user auxUser = userFirst;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("| {0,-10} | {1,-30} |", "ID", "Nombre");
        Console.WriteLine("-----------------------------------------------");
        while (auxUser != null)
        {
            if (auxUser.getUserAdmin() == true)
            {
                Console.WriteLine("| {0,-10} | {1,-30} |", auxUser.getUserID(), auxUser.getUserName());
            }
            auxUser = auxUser.getNextUser();
        }
        Console.WriteLine("-----------------------------------------------");
    }
    public void printUserCustomer()
    {
        user auxUser = userFirst;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("| {0,-10} | {1,-30} |", "ID", "Nombre");
        Console.WriteLine("-----------------------------------------------");
        while (auxUser != null)
        {
            if (auxUser.getUserAdmin() == false)
            {
                Console.WriteLine("| {0,-10} | {1,-30} |", auxUser.getUserID(), auxUser.getUserName());
            }
            auxUser = auxUser.getNextUser();
        }
        Console.WriteLine("-----------------------------------------------");
    }
}