
using _7Lesson;
using _7Lesson.Models;

var travel = new Travel(new Car());
travel.GoToTravel();
travel.SetTransport(new Boat());
travel.GoToTravel();

public class Travel
{
    public string Name = "123";
    private IMovable _movable;

    public Travel(IMovable movable)
    {
        _movable = movable;
    }

    public void SetTransport(IMovable movable)
    {
        _movable = movable;
    }


    public void GoToTravel()
    {
        _movable.Move();
    }
}