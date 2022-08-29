using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.CommandValues;

namespace StorybrewScripts
{
    public class Text : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            StoryboardLayer mainLayer = GetLayer("Main");

            var text1 = mainLayer.CreateSprite("SB/text1.png");
            var text2 = Beatmap.Name == "Ninym's Hard" ? 
                mainLayer.CreateSprite("SB/text2b.png") : mainLayer.CreateSprite("SB/text2.png");
            var text3 = mainLayer.CreateSprite("SB/text3.png");
            var text4 = mainLayer.CreateSprite("SB/text4.png");
            var text5 = mainLayer.CreateSprite("SB/text5.png");

            text1.Move(21540, 24237, new CommandPosition(180, 360), new CommandPosition(190, 360));
            text1.Additive(21540);
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
