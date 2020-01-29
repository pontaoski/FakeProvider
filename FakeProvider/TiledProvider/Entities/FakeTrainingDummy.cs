﻿#region Using
using Terraria.DataStructures;
using Terraria.GameContent.Tile_Entities;
using Terraria.ID;
#endregion
namespace FakeProvider
{
    public class FakeTrainingDummy : TETrainingDummy, IFake
    {
        #region Data

        public INamedTileCollection Provider { get; }
        public int Index
        {
            get => ID;
            set => ID = value;
        }
        public int X
        {
            get => Position.X;
            set => Position = new Point16((short)value, Position.Y);
        }
        public int Y
        {
            get => Position.Y;
            set => Position = new Point16(Position.X, (short)value);
        }
        internal static ushort[] _TileTypes = new ushort[]
        {
            TileID.TargetDummy
        };
        public ushort[] TileTypes => _TileTypes;
        public int RelativeX { get; set; }
        public int RelativeY { get; set; }

        #endregion

        #region Constructor

        public FakeTrainingDummy(INamedTileCollection Provider, int Index, int X, int Y)
        {
            this.Provider = Provider;
            this.ID = Index;
            this.RelativeX = X;
            this.RelativeY = Y;
            this.Position = new Point16(X, Y);
            this.type = 0;
        }

        #endregion
    }
}