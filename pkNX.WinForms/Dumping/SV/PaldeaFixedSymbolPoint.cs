using pkNX.Structures.FlatBuffers;

namespace pkNX.WinForms;

public class PaldeaFixedSymbolPoint
{
    public string TableKey;
    public PackedVec3f Position;

    public PaldeaFixedSymbolPoint(string key, PackedVec3f pos)
    {
        TableKey = key;
        Position = new PackedVec3f
        {
            X = pos.X,
            Y = pos.Y,
            Z = pos.Z,
        };
    }

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
