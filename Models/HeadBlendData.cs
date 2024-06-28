using System.Runtime.InteropServices;

namespace MaskFix.Models 
{
    /// <summary>
    /// Represents the native structure layout for head blend data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HeadBlendDataStruct
    {
        public int shapeFirst;
        public int padding1;
        public int shapeSecond;
        public int padding2;
        public int shapeThird;
        public int padding3;
        public int skinFirst;
        public int padding4;
        public int skinSecond;
        public int padding5;
        public int skinThird;
        public int padding6;
        public float shapeMix;
        public int padding7;
        public float skinMix;
        public int padding8;
        public float thirdMix;
        public int padding9;
        [MarshalAs(UnmanagedType.I1)]
        public bool isParent;
    }

    /// <summary>
    /// Represents the high-level abstraction of head blend data.
    /// </summary>
    public class HeadBlendData
    {
        public int ShapeFirst { get; set; }
        public int ShapeSecond { get; set; }
        public int ShapeThird { get; set; }
        public int SkinFirst { get; set; }
        public int SkinSecond { get; set; }
        public int SkinThird { get; set; }
        public float ShapeMix { get; set; }
        public float SkinMix { get; set; }
        public float ThirdMix { get; set; }
    }
}
