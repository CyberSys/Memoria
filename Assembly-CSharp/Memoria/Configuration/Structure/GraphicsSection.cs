using System;
using Memoria.Prime.Ini;

namespace Memoria
{
    public sealed partial class Configuration
    {
        private sealed class GraphicsSection : IniSection
        {
            public readonly IniValue<Int32> BattleFPS;
            public readonly IniValue<Int32> BattleTPS;
            public readonly IniValue<Int32> FieldFPS;
            public readonly IniValue<Int32> FieldTPS;
            public readonly IniValue<Int32> WorldFPS;
            public readonly IniValue<Int32> WorldTPS;
            public readonly IniValue<Int32> MenuFPS;
            public readonly IniValue<Int32> MenuTPS;
            public readonly IniValue<Int32> BattleSwirlFrames;
            public readonly IniValue<Boolean> WidescreenSupport;
            public readonly IniValue<Int32> TileSize;
            public readonly IniValue<Int32> AntiAliasing;
            public readonly IniValue<Int32> SkipIntros;
            public readonly IniValue<Int32> GarnetHair;

            public GraphicsSection() : base(nameof(GraphicsSection), false)
            {
                BattleFPS = BindInt32(nameof(BattleFPS), 30);
                BattleTPS = BindInt32(nameof(BattleTPS), 15);
                FieldFPS = BindInt32(nameof(FieldFPS), 30);
                FieldTPS = BindInt32(nameof(FieldTPS), 30);
                WorldFPS = BindInt32(nameof(WorldFPS), 20);
                WorldTPS = BindInt32(nameof(WorldTPS), 20);
                MenuFPS = BindInt32(nameof(MenuFPS), 60);
                MenuTPS = BindInt32(nameof(MenuTPS), 60);
                BattleSwirlFrames = BindInt32(nameof(BattleSwirlFrames), 115);
                WidescreenSupport = BindBoolean(nameof(WidescreenSupport), true);
                TileSize = BindInt32(nameof(TileSize), 32);
                AntiAliasing = BindInt32(nameof(AntiAliasing), 0);
                SkipIntros = BindInt32(nameof(SkipIntros), 0);
                GarnetHair = BindInt32(nameof(GarnetHair), 0);
            }
        }
    }
}
