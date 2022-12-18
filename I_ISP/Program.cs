// Bad Example
//public interface Teacher
//{

//    void English();

//    void Biology();

//    void Chemistry();

//    void Mathematics();

//}

//public class Jane:Teacher
//{

//public void English()
//{
//   Console.WriteLine("Jane is teaching the students English language.");
//}


//    public void Biology()
//   {


//    }


//    public void Chemistry()
//{
//}


//    public void Mathematics()
//    {
//    }


//}


// Good Example


public interface Teacher
{

    void Teach();

}


public interface EnglishTeacher: Teacher
{

    void English();

}


public interface BiologyTeacher : Teacher
{

    void Bilogy();

}


public interface ChemistryTeacher : Teacher
{

    void Chemistry();

}


public interface MathematicsTeacher : Teacher
{

    void Mathematics();

}


public class Jane : EnglishTeacher
{

    public void Teach()
{
        Console.WriteLine("Jane has started teaching.");
}


    public void English()
{
   Console.WriteLine("Jane is teaching the students English language.");
}

}

