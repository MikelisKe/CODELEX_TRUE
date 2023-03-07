using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Exercise_6;

public class Dog
{
    private string _sex;
    private string _name;
    public Dog _mother;
    public Dog _father;

    public Dog(string name, string sex ) 
    {
        _sex = sex;
        _name = name;
    }
    public Dog Mother
    {
        get => _mother;
        set => _mother = value;
    }

    public Dog Father
    {
        get => _father;
        set => _father = value;
    }

    public string FathersName()
    {
        if (_father == null)
        {
            return "Unknown";
        }
        else
        {
            return _father._name;
        }
    }

    public bool HasSameMotherAs(Dog otherDog)
        {
            if (_mother == null || otherDog.Mother == null)
            {
                return false;
            }
            else
            {
                return _mother == otherDog.Mother;
            }
        }

    }
