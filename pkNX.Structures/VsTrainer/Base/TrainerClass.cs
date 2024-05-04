namespace pkNX.Structures;

public abstract class TrainerClass(byte[] data)
{
    public abstract int SIZE { get; }
    protected readonly byte[] Data = data;

    public virtual int Gender { get; set; }
    public virtual int Multi { get; set; }
    public virtual int Group { get; set; }
    public virtual int BallID { get; set; } = 4;
    public virtual int BattleBackground { get; set; }
    public virtual int EyeCatchBGM { get; set; }

    public virtual bool IsBoss => false;
    public virtual int MegaItemID => 773;
}
