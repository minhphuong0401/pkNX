namespace pkNX.Structures.FlatBuffers;

public class PaldeaFixedSymbolPoint(string key, PackedVec3f pos)
{
    public string TableKey = key;
    public PackedVec3f Position = new()
    {
        X = pos.X,
        Y = pos.Y,
        Z = pos.Z,
    };

    public PaldeaFixedSymbolPoint DeepCopy()
    {
        PackedVec3f NewPosition = new PackedVec3f
        {
            X = this.Position.X,
            Y = this.Position.Y,
            Z = this.Position.Z,
        };
        PaldeaFixedSymbolPoint deepcopyPoint = new PaldeaFixedSymbolPoint(this.TableKey, NewPosition);

        return deepcopyPoint;
    }
}
