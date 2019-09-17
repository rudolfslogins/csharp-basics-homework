namespace DragRace
{
    public interface ICar
    {
        string Name();

        void SpeedUp();

        void SlowDown();

        string ShowCurrentSpeed();

        void StartEngine();
    }
}