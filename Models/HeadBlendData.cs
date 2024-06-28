using System.Runtime.InteropServices;

namespace MaskFix.Models 
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct HeadBlendData
    {
        [FieldOffset(0)]
        public int ShapeFirst;

        [FieldOffset(8)]
        public int ShapeSecond;

        [FieldOffset(16)]
        public int ShapeThird;

        [FieldOffset(24)]
        public int SkinFirst;

        [FieldOffset(32)]
        public int SkinSecond;

        [FieldOffset(40)]
        public int SkinThird;

        [FieldOffset(48)]
        public float ShapeMix;

        [FieldOffset(56)]
        public float SkinMix;

        [FieldOffset(64)]
        public float ThirdMix;
    }
}
