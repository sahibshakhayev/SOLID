// Bad Example
//public class Bank
//{

//    public void GIVE_CUSTOMER_MONEY_OTC()
//    {
//        // some logic
//    }
//}



//public class Customer
//{
//    private Bank myBank = new Bank();

//    public void withdraw()
//    {
//        myBank.GIVE_CUSTOMER_MONEY_OTC();
//    }
//}


// Good Example

public interface ATM
{
    void ATM_OPERATION();
}


public class Bank : ATM
{

    public void ATM_OPERATION(){
        // code 
    }
}


public class Customer : ATM
{

    
    public void ATM_OPERATION(){
        // code
    }
}



