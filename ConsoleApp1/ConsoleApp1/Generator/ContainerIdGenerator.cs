namespace ConsoleApp1.Containers;

public class ContainerIdGenerator
{
    private static Dictionary<string, int> _lastIdByType = new Dictionary<string, int>();

    public static string GenerateId(string containerType)
    {
        if (!_lastIdByType.ContainsKey(containerType))
        {
            _lastIdByType[containerType] = 0;
        }

        _lastIdByType[containerType]++;
        return $"KON-{containerType}-{_lastIdByType[containerType]}";
    }
}