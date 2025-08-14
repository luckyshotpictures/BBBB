using Robust.Shared.Maths;

namespace Content.Shared.Signs;

public static class DynamicSignsDir
{
    public static readonly Direction[] Cardinals =
    {
        Direction.North,
        Direction.South,
        Direction.East,
        Direction.West,
    };

    public static bool IsCardinal(Direction d) =>
        d is Direction.North or  Direction.South or Direction.East or Direction.West;
}
