using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.CommandValues;
using System;

namespace StorybrewScripts
{
    public class Petals : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer mainLayer = GetLayer("Main");
            Random r = new Random();
            double start = 64687;
            double end = 86260;

            // 640x480
            for (int i = 0; i < 64; i++)
            {
                OsbSprite petal = mainLayer.CreateSprite("SB/Petal.png");

                double startTime = start + r.NextDouble() * (end - start);
                double startX = 100 + r.NextDouble() * 700;
                double weight = 0.1 + r.NextDouble() * 0.4;
                double endTime = startTime + (5000 + weight * 15000);

                petal.Additive(startTime);
                petal.Color(startTime, Color4.Pink);
                petal.Fade(startTime, 0.8);

                petal.Scale(startTime, weight);
                double startRotation = r.NextDouble() * Math.PI;
                petal.Rotate(startTime, endTime, startRotation, startRotation + (4 - weight * 2) * Math.PI);

                petal.Move(startTime, endTime,
                    new CommandPosition(startX, -25), 
                    new CommandPosition(startX - (256 + r.NextDouble() * 128), 640 - weight * 320));
            }

            var text1 = mainLayer.CreateSprite("SB/text1.png");
            var text2 = mainLayer.CreateSprite("SB/text2.png");
            var text3 = mainLayer.CreateSprite("SB/text3.png");
            var text4 = mainLayer.CreateSprite("SB/text4.png");
            var text5 = mainLayer.CreateSprite("SB/text5.png");

            text1.Move(21540, 24237, new CommandPosition(180, 360), new CommandPosition(190, 360));
            text1.Additive(21878);
            text1.Fade(21540, 21878, 0, 1);
            text1.Fade(23900, 24237, 1, 0);

            text2.Move(24237, 26934, new CommandPosition(470, 360), new CommandPosition(480, 360));
            text2.Additive(24237);
            text2.Fade(24237, 24574, 0, 1);
            text2.Fade(26597, 26934, 1, 0);

            text3.Move(26934, 29630, new CommandPosition(180, 360), new CommandPosition(190, 360));
            text3.Additive(26934);
            text3.Fade(26934, 27271, 0, 1);
            text3.Fade(29293, 29630, 1, 0);

            text4.Move(29630, 32327, new CommandPosition(470, 360), new CommandPosition(480, 360));
            text4.Additive(29630);
            text4.Fade(29630, 29967, 0, 1);
            text4.Fade(31990, 32327, 1, 0);

            text5.Move(108170, new CommandPosition(180, 360));
            text5.Color(108170, Color4.DarkViolet);
            text5.Fade(108170, 108507, 0, 1);
            text5.Fade(110915, 1);
        }
    }
}
