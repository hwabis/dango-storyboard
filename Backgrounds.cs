using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.CommandValues;

namespace StorybrewScripts
{
    public class Backgrounds : StoryboardObjectGenerator
    {
        private StoryboardLayer mainLayer;

        private double beatLength;

        public override void Generate()
        {
            mainLayer = GetLayer("Main");
            beatLength = Beatmap.GetTimingPointAt(0).BeatDuration;

            OsbSprite bg01 = generateCorrectlySizedBackground("BG-01.jpg", OsbOrigin.Centre);
            OsbSprite bg02 = generateCorrectlySizedBackground("BG-02.jpg", OsbOrigin.Centre);
            OsbSprite bg03 = generateCorrectlySizedBackground("BG-03.png", OsbOrigin.Centre);
            OsbSprite bg04 = generateCorrectlySizedBackground("BG-04.jpg", OsbOrigin.Centre);
            OsbSprite bg05 = generateCorrectlySizedBackground("SB/BG-05.jpg", OsbOrigin.Centre);
            OsbSprite bg06 = generateCorrectlySizedBackground("SB/BG-06.jpg", OsbOrigin.Centre);
            OsbSprite bg07 = generateCorrectlySizedBackground("SB/BG-07.jpg", OsbOrigin.Centre);
            OsbSprite bg08 = generateCorrectlySizedBackground("SB/BG-08.jpg", OsbOrigin.Centre);
            OsbSprite bg09 = generateCorrectlySizedBackground("SB/BG-09.jpg", OsbOrigin.Centre);
            OsbSprite bgFinal = generateCorrectlySizedBackground("SB/FINAL BG.jpg", OsbOrigin.Centre);

            OsbSprite white = generateCorrectlySizedBackground("SB/white.png", OsbOrigin.Centre);

            double end01 = 11091;
            bg01.Fade(0, 5698, 0, 1);
            bg01.Fade(end01 - beatLength, end01, 1, 0);
            bg01.Scale(0, end01, bg01.ScaleAt(0).X + 0.03, bg01.ScaleAt(0).X + 0.06);
            bg01.Move(0, end01,
                bg01.PositionAt(0) + new CommandPosition(45, 0),
                bg01.PositionAt(0) + new CommandPosition(60, 15));

            double end02 = 21878;
            bg02.Fade(end01 - beatLength, end01, 0, 1);
            bg02.Fade(end02 - beatLength, end02, 1, 0);
            bg02.Scale(end01 - beatLength, end02, bg02.ScaleAt(0).X + 0.06, bg02.ScaleAt(0).X + 0.03);
            bg02.Move(end01 - beatLength, end02,
                bg02.PositionAt(end01 - beatLength) + new CommandPosition(0, 15),
                bg02.PositionAt(end01 - beatLength) + new CommandPosition(30, 0));

            double end03 = 32664;
            bg03.Fade(end02 - beatLength, end02, 0, 0.75);
            bg03.Fade(end03 - beatLength, end03, 0.75, 0);
            bg03.Scale(end02 - beatLength, end03, bg03.ScaleAt(0).X, bg03.ScaleAt(0).X + 0.03);
            bg03.Move(end02 - beatLength, end03,
                bg03.PositionAt(end02 - beatLength),
                bg03.PositionAt(end02 - beatLength) + new CommandPosition(0, -15));

            double end05 = 43451;
            bg05.Fade(end03 - beatLength, end03, 0, 1);
            bg05.Fade(end05 - beatLength, end05, 1, 0);
            bg05.Scale(end03 - beatLength, end05, bg05.ScaleAt(0).X + 0.07, bg05.ScaleAt(0).X + 0.04);
            bg05.Move(end03 - beatLength, end05,
                bg05.PositionAt(end03 - beatLength) + new CommandPosition(30, -15),
                bg05.PositionAt(end03 - beatLength) + new CommandPosition(0, 0));

            double end06 = 54237;
            bg06.Fade(end05 - beatLength, end05, 0, 1);
            bg06.Fade(end06 - beatLength, end06, 1, 0);
            bg06.Scale(end05 - beatLength, bg06.ScaleAt(0).X + 0.01);
            bg06.Move(end05 - beatLength, end06,
                bg06.PositionAt(end05 - beatLength) + new CommandPosition(-15, 0),
                bg06.PositionAt(end05 - beatLength) + new CommandPosition(75, 0));

            double end07 = 65024;
            bg07.Fade(end06 - beatLength, end06, 0, 1);
            bg07.Fade(end07 - beatLength / 2, end07 + beatLength / 2, 1, 0);
            bg07.Scale(end06 - beatLength, end07 + beatLength / 2, bg07.ScaleAt(0).X + 0.03, bg07.ScaleAt(0).X + 0.06);
            bg07.Move(end06 - beatLength, end07 + beatLength / 2,
                bg07.PositionAt(end06 - beatLength) + new CommandPosition(-15, -15),
                bg07.PositionAt(end06 - beatLength) + new CommandPosition(15, 15));

            white.Fade(end07 - beatLength * 4, end07, 0, 0.8);
            white.Fade(end07, end07 + beatLength * 2, 0.8, 0);

            double end04 = 86597;
            bg04.Fade(end07 - beatLength / 2, end07 + beatLength / 2, 0, 1);
            bg04.Fade(end04 - beatLength, end04, 1, 0);
            bg04.Scale(end07 - beatLength / 2, end04, bg04.ScaleAt(0).X, bg04.ScaleAt(0).X + 0.04);

            double end08 = 97383;
            bg08.Fade(end04 - beatLength, end04, 0, 1);
            bg08.Fade(end08 - beatLength, end08, 1, 0);
            bg08.Scale(end04 - beatLength, end08, bg08.ScaleAt(0).X + 0.04, bg08.ScaleAt(0).X);

            double end09 = 108170;
            bg09.Fade(end08 - beatLength, end08, 0, 1);
            bg09.Fade(end08, end09 - beatLength * 2, 1, 0.75);
            bg09.Fade(end09 - beatLength * 2, end09, 0.75, 0);
            bg09.Rotate(end08 - beatLength, end09, 0, -0.1);
            bg09.Scale(end08 - beatLength, end09, 0.5, 0.45);

            bgFinal.Fade(end09 - beatLength * 4, end09 - beatLength, 0, 0.8);
            bgFinal.Fade(110915, 1);
        }

        private OsbSprite generateCorrectlySizedBackground(string path, OsbOrigin origin)
        {
            OsbSprite background = mainLayer.CreateSprite(path, origin);
            background.Scale(0, 480.0f / GetMapsetBitmap(path).Height);
            background.Fade(0, 0);

            return background;
        }
    }
}