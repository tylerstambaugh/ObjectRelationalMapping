// https://exercism.org/tracks/csharp/exercises/object-relational-mapping/


using System.Data.Entity;

public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Begin()
    {
        throw new NotImplementedException($"Please implement the Orm.Begin() method");
    }

    public void Write(string data)
    {
        throw new NotImplementedException($"Please implement the Orm.Write() method");
    }

    public void Commit()
    {
        throw new NotImplementedException($"Please implement the Orm.Commit() method");
    }
}
