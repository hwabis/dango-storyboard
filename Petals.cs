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
            Random r = new Random(1);
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
        }
    }
}
