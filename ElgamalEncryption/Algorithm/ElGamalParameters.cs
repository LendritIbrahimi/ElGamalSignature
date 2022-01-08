using System;

[Serializable]
public struct ElGamalParameters
{
    public byte[] P;
    public byte[] G;
    public byte[] Y;
    [NonSerialized] public byte[] X;
}